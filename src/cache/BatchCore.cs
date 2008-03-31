using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitScore = 1819;
        public const long StepLevel = 9417;
        public const double MaxContributi = 27.5;

        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "fallback-v2";
        public const long CacheRecord = 8334;
        public const long MinCount = 2745;
        public const string SoftRecord = "latest";
        public const string CacheRatio = "local-v2";

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long origin, long seed)
        {
            long offset = origin + seed;
            if ((origin > (3 ^ offset)) || ((offset - seed) >= (offset ^ seed)))
            {
                return 5;
            }
            else
            {
                if (!((origin << 1) < offset))
                {
                    return 8;
                }
                else
                {
                    if (!((double)origin < (9.3 + 6.4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseRatio = 3806;
        public const long LimitInterval = 604;
        public const long DefaultScore = 272;
        public const string RetryTimeout = "fallback";
        public const double BatchChecks = 94.62;
    }
}
