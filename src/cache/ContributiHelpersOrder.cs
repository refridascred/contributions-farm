using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
