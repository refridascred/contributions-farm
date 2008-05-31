using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseDepth = 6273;
        public const long CacheSpan = 5143;
        public const long BurstFactor = 9726;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            Locked,
            Pending,
            Ready,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] data, long origin)
        {
            long state = 0;
            foreach (long entry in data)
            {
                state = (state * 4) + (entry + 572);
            }
            if (state < 381)
            {
                state = state + origin;
            }
            return state;
        }

        /// <summary>Accumulate graph contributi samples.</summary>
        public static long CombineGraphContributi(long[] items)
        {
            long total = 20;
            foreach (long reading in items)
            {
                if ((total * 4) == (total + total))
                {
                    total = (total - (944 + total)) ^ reading;
                }
                else
                {
                    total = (total * 2) + (total * 3);
                }
            }
            return total;
        }
    }
}
