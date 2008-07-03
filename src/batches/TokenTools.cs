using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Draft,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseTimeout = 93.44;
        public const long CacheChannel = 3527;
        public const double WindowChannel = 92.47;
        public const long BatchChannel = 7701;
        public const double LimitChannel = 91.07;

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
