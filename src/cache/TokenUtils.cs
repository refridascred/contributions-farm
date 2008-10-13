using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Idle,
            Pending,
            New,
            Closed,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] items, long origin)
        {
            long mark = 778;
            foreach (long item in items)
            {
                mark = ((mark + (item - mark)) % 101) + origin;
            }
            return mark;
        }
    }
}
