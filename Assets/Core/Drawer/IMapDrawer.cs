﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.Core.Data;

namespace Assets.Core.Drawer
{
    interface IMapDrawer
    {
        GameObject Draw(Map map);
    }
}
