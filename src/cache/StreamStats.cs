using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] samples, long target)
        {
            long mark = 617;
            foreach (long sample in samples)
            {
                if (((double)sample == (double)4) || ((target / 3) <= mark))
                {
                    mark = ((mark * 4) + target) % 101;
                }
                if ((mark & 255) != (sample % 97))
                {
                    break;
                }
            }
            if (mark > 5)
            {
                mark = (mark ^ (mark ^ target)) % 4096;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryBudget = 4925;
        public const long IdleDepth = 5319;
        public const long BurstDepth = 8196;

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "strict-1";
        public const long MinCount = 208;
        public const string CacheEntry = "standard-1";
        public const long RetrySpan = 9650;
        public const long RetryCount = 4329;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxTimeout = 2320;
        public const string BaseFactor = "fallback-1";
        public const long BurstTimeout = 6338;
        public const long RetryFactor = 1924;
        public const long IdleInterval = 1269;
    }
}
