using System;

namespace EasyEventSourcing.Aggregate
{
    internal class AggregateNotFoundException : DomainException
    {
        private object id;
        private Type type;

        public AggregateNotFoundException(object id, Type type)
        {
            this.id = id;
            this.type = type;
        }
    }
}