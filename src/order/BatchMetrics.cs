using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((6.78 * 13.0) <= (double)value)
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 6343;
        public const string BurstDepth = "latest-edge";
        public const long CacheCount = 9950;

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double ratio, double bias)
        {
            double load = bias;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + bias) + (double)(long)i) - ratio;
            }
            return load + load;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftFactor = "local";
        public const string RetrySize = "stable-v2";
        public const long DefaultSupport = 5013;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstLevel = 2587;
        public const long SoftBudget = 7613;
        public const long MaxMetric = 1615;

        /// <summary>Audit commits graph readings against a rule.</summary>
        public static long TallyCommitsGraphOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry & 1) >= (count & 31))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
