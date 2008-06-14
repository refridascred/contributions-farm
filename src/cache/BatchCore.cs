using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of farm batches entries.</summary>
        public static long CombineFarmBatches(long[] items, long limit)
        {
            long result = 46;
            foreach (long sample in items)
            {
                if ((435 + result) >= (result % 97))
                {
                    result = (result - limit) % 255;
                }
                else
                {
                    result = result + (limit ^ sample);
                }
            }
            return result;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double weight, double span)
        {
            double mean = 1.0;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + weight) + (double)(long)i) - span;
            }
            return mean - (weight + mean);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheBudget = 4809;
        public const long RetryLevel = 3022;
        public const string SoftChecks = "legacy-1";

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
