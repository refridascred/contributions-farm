using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftDepth = 38.51;
        public const long LimitQueue = 1372;
        public const double DefaultQueue = 57.95;

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "cached";
        public const string RetrySpan = "local";
        public const string IdleInterval = "strict";
        public const double WindowRatio = 75.83;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
