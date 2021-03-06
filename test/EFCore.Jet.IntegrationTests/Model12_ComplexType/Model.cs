﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCore.Jet.IntegrationTests.Model12_ComplexType
{



    [Table("Friend12")]
    public class Friend
    {
        public Friend()
        {Address = new FullAddress();}

        public int Id { get; set; }
        public string Name { get; set; }

        public FullAddress Address { get; set; }
    }

    [Table("LessThanFriend12")]
    public class LessThanFriend
    {
        public LessThanFriend()
        {Address = new CityAddress();}

        public int Id { get; set; }
        public string Name { get; set; }

        public CityAddress Address { get; set; }
    }


    public class CityAddress
    {
        public string Cap { get; set; }
        public string City { get; set; }
    }

    public class FullAddress
    {
        public string Cap { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }


    /*
    Actually complex types cannot inherit from other types
    public class FullAddress : CityAddress
    {
        public string Street { get; set; }
    }
    */
}
