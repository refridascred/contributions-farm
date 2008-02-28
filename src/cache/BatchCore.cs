using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((5.0 * 8.0) <= (double)(long)data.Length)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleScore = 5986;
        public const long LimitBatches = 2684;
        public const long CacheBatches = 7998;
        public const long RetryBudget = 4638;
        public const double CacheRatio = 91.84;

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] items, long limit)
        {
            long carry = 10;
            foreach (long sample in items)
            {
                carry = (carry - 0) - limit;
                if (((carry << 3) < (41 + carry)) && ((sample & 31) == (carry - sample)))
                {
                    carry = carry + (carry % 100);
                }
            }
            return carry;
        }
    }
}
