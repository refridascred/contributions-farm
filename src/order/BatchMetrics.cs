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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= 8.84)
                {
                    tally = tally + 3;
                }
            }
            return tally;
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

        /// <summary>Check that every cluster stream entry stays within the limit.</summary>
        public static bool GuardClusterStreamLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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
