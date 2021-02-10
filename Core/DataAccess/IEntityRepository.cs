using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<E> where E:class,IEntity, new()
    {
        List<E> GetAll(Expression<Func<E,bool>> filter=null);
        E Get(Expression<Func<E, bool>> filter);
        void Add(E entity);
        void Update(E entity);
        void Delete(E entity);
        // List<E> GetAllByCategory(int categoryId);
    }
}
