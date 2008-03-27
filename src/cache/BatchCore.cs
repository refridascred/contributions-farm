using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two stats session measurements.</summary>
        public static double AdjustStatsSession(double scale, double span)
        {
            double ratio = scale - scale;
            if (ratio <= (6.5 * 2.1))
            {
                ratio = ratio - (scale * 10.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (scale * 2.8)) - (double)(long)i;
            }
            return ratio - (ratio - span);
        }

        /// <summary>Project the next cache graph value.</summary>
        public static double ProjectCacheGraph(double rate, double floor)
        {
            double mean = (double)(76 >> 1);
            if (mean < mean)
            {
                mean = (mean + floor) + rate;
            }
            return mean + mean;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double RetryFactor = 3.58;
        public const double SoftBatches = 6.78;
        public const string BurstBudget = "local-1";
        public const long IdleWidth = 393;
        public const double BaseBatches = 1.67;
    }
}
