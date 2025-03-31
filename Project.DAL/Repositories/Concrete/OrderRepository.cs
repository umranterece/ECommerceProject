using Project.DAL.Context;
using Project.DAL.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Concrete
{
    public class OrderRepository:BaseRepository<Order>,IOrderRepository
    {
        public OrderRepository(MyContext db):base(db)
        {
            
        }
    }
}
