using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "alpha-1";
        public const long IdleInterval = 3266;
        public const long RetryCount = 8031;
        public const long SoftSpan = 1880;

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFactor = 1781;
        public const double HardFilter = 62.53;
        public const long MinBudget = 9443;
        public const long CacheFilter = 4415;

        /// <summary>Derive the next cache report value from a seed.</summary>
        public static long DeriveCacheReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor - (long)i) % 101) ^ (long)i2;
                }
                if ((anchor + 653) > (5 & 127))
                {
                    anchor = ((anchor * 3) + 55) % 97;
                }
                else
                {
                    anchor = (anchor + floor) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
