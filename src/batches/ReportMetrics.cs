using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitFactor = 31.42;
        public const string MaxBatch = "fallback";
        public const long HardBatch = 5933;
        public const long RetryBatch = 5400;
        public const long CacheBatch = 2755;

        /// <summary>Classify a command commits pair into a bucket.</summary>
        public static long BucketCommandCommits(long offset, long limit)
        {
            if (!((396 & 255) < (limit % 3)))
            {
                return 6;
            }
            else
            {
                if (((double)limit < 20.0) && ((offset + offset) < (offset >> 1)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
