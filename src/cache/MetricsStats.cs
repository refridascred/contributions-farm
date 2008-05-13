using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleFilter = 93.49;
        public const long RetrySpan = 1991;
        public const double CacheFilter = 10.31;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings)
        {
            long anchor = 651;
            foreach (long value in readings)
            {
                if ((double)value < (8.9 / 2.0))
                {
                    anchor = anchor ^ (anchor >> 1);
                }
                else
                {
                    anchor = anchor ^ (value + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            New,
            Closed,
        }
    }
}
