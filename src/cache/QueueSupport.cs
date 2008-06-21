using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Dropped,
            Failed,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
