﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital.Models
{
    public class Cart
    {
        public string Id { get; set; }
        public List<SaleLine> ProductLines {get;set;}
    }
}
