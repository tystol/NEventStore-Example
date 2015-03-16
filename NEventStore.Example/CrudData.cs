using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace NEventStore.Example
{
    public class Foo
    {
        public int Id { get; set; }
        public string Bar { get; set; }
    }
    public class CrudContext : DbContext
    {
        public CrudContext()
            : base("EventStore")
        {
        }

        public DbSet<Foo> Data { get; set; }
    }
}
