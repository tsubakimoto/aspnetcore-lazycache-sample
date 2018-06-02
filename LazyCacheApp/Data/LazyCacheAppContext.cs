using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LazyCacheApp.Models
{
    public class LazyCacheAppContext : DbContext
    {
        public LazyCacheAppContext (DbContextOptions<LazyCacheAppContext> options)
            : base(options)
        {
        }

        public DbSet<LazyCacheApp.Models.Product> Product { get; set; }
    }
}
