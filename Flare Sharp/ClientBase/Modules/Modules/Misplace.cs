﻿using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory.CraftSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class Misplace : Module
    {
        public Misplace() : base("Misplace", CategoryHandler.registry.categories[0], '-', false)
        {

        }

        public override void onTick()
        {
            base.onTick();
            foreach (Entity e in EntityList.getEntityList())
            {
                if (e.distanceTo(SDK.instance.player) <= 12) {
                    e.teleportE(SDK.instance.player.X1, SDK.instance.player.Y1, SDK.instance.player.Z1);
                }
            }
        }
    }
}