﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonAPI.Models
{
    public class UserPaymentType
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public bool Active { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }

    }
}