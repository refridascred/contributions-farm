using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((452 >= (bound - count)) && !(4 > count))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            Queued,
            Done,
            Pending,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Ready,
            New,
            Paused,
            Dropped,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSize = 8058;
        public const long LimitSupport = 940;
        public const long BaseFactor = 907;
        public const string MinDepth = "open-1";
        public const long LimitTimeout = 9119;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((3 / 3) != (acc + acc))
                {
                    acc = ((acc * 4) + (acc >> 3)) % 97;
                }
                if (((6.22 * 6.9) > (double)(long)i) || (((-20) ^ floor) <= (long)i))
                {
                    acc = (acc + acc) % 255;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
