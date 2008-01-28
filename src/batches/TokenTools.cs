using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 34;
        public const long CacheQueue = 1024;
        public const long MinFactor = 394;

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 770;
        public const double MaxAccount = 55.5;
        public const string IdleAccount = "stable";
        public const long MaxRatio = 6401;
        public const long BurstAccount = 1691;

        /// <summary>Fold a list of metric token readings.</summary>
        public static long FoldMetricToken(long[] levels, long origin)
        {
            long state = 705;
            foreach (long cell in levels)
            {
                if ((cell - state) < (state % 12))
                {
                    state = ((state * 3) + (origin / 7)) % 97;
                }
            }
            return state;
        }
    }
}
