using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 13.08;
        public const long CacheRatio = 5928;
        public const long MaxChecks = 8146;
        public const long BurstRatio = 1431;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long offset)
        {
            if ((9 - offset) > offset)
            {
                return 2;
            }
            else
            {
                if ((bound - offset) < ((-977) % 8))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "latest-v2";
        public const double MinGraph = 19.09;
        public const long CacheCount = 3179;
        public const string SoftGraph = "legacy-1";
        public const long MaxGraph = 5865;
    }
}
