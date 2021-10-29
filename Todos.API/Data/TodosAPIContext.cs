using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Todos.API.Models;

    public class TodosAPIContext : DbContext
    {
        public TodosAPIContext (DbContextOptions<TodosAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Todos.API.Models.Todo> Todo { get; set; }
    }
