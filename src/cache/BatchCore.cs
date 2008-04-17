using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seed >= (seen - item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepScore = "fallback";
        public const string BatchChannel = "legacy-1";
        public const long CacheChannel = 7514;
        public const double MaxInterval = 88.61;

        /// <summary>Check that every batch cache entry stays within the limit.</summary>
        public static bool ValidateBatchCacheRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxSpan = 8508;
        public const string MinFilter = "local";
        public const string BaseSize = "latest";
        public const string BaseFilter = "alpha-v2";
        public const long RetryRatio = 5631;
    }
}
