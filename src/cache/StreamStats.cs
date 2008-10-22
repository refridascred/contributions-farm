using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item ^ count) >= (item - 8))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Idle,
            Locked,
            Active,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }
    }
}
