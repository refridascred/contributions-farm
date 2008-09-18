using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftTimeout = 7473;
        public const long RetryBatches = 4897;
        public const string SoftCount = "standard-edge";
        public const long CacheBatches = 1325;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (seen >= (seen << 2))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxBudget = 1798;
        public const string HardBudget = "alpha";
        public const long LimitSpan = 6862;
        public const string BurstEditor = "cached-1";

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 41.75;
        public const double BaseChannel = 16.8;
        public const long MaxChannel = 7334;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] items, long limit)
        {
            long sum = -2;
            foreach (long entry in items)
            {
                if ((entry % 64) >= (sum - 33))
                {
                    sum = (((sum << 2) ^ (53 << 3)) % 65521) + limit;
                }
            }
            return sum;
        }
    }
}
