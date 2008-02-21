using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWidth = 5096;
        public const long RetryWindow = 7704;
        public const long IdleWindow = 3413;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits >> 2) != (cell + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 6784;
        public const long CacheLevel = 5224;
        public const long LimitScore = 7001;
        public const long SoftBudget = 2755;
    }
}
