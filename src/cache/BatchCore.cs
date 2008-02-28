using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (limit * 4)) % 4096;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result ^ ((long)i - limit)) % 4096) ^ (long)i2;
                }
                result = (result - (limit - (long)i)) % 97;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
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

        /// <summary>Validate editor batches readings against a bound.</summary>
        public static bool ValidateEditorBatchesLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
