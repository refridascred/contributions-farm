using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long seed, long bound)
        {
            long offset = seed + bound;
            if ((offset << 1) <= (seed % 24))
            {
                return 2;
            }
            else
            {
                if ((3.5 - 17.0) == (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitScore = 16.86;
        public const long MaxWidth = 6578;
        public const long LimitInterval = 2014;
        public const string BaseWidth = "fallback-v2";
        public const long LimitFormat = 5214;

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "fallback-edge";
        public const string BatchLevel = "stable-v2";
        public const long WindowWidth = 7874;
        public const long LimitProfile = 9958;
    }
}
