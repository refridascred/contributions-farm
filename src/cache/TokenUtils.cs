using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 7862;
        public const double BatchLevel = 41.63;
        public const double WindowCount = 14.86;
        public const long SoftStats = 5818;
        public const long RetryStats = 6890;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            New,
            Draft,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] levels, long limit)
        {
            long anchor = 91;
            foreach (long value in levels)
            {
                anchor = ((anchor - (value - value)) % 97) + limit;
            }
            return anchor;
        }
    }
}
