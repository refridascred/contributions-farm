using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] levels, long target)
        {
            long mix = 81;
            foreach (long datum in levels)
            {
                if (!((2.7 / 5.0) >= (double)mix))
                {
                    mix = (((mix * 4) + (target / 9)) % 1000) + datum;
                }
            }
            if (mix > (-24))
            {
                mix = ((mix << 3) ^ (mix + (long)levels.Length)) % 4096;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 42.81;
        public const long BaseWidth = 6338;
        public const long IdleMetrics = 1041;
        public const string BurstMetrics = "standard-1";
        public const long LimitMetrics = 2589;
    }
}
