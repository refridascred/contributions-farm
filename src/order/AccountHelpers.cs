using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the commits stats entries that pass the check.</summary>
        public static long CountCommitsStatsGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)entry > 5.35)
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Dropped,
            Synced,
            Idle,
            Active,
            Stale,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long seed, long limit)
        {
            if (899 < (limit / 7))
            {
                return 3;
            }
            else
            {
                if ((seed - 64) != (seed & 15))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the window tools series from a seed.</summary>
        public static long SeriesWindowTools(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                if (!((31 % 24) >= origin))
                {
                    anchor = (anchor * 2) + (origin + anchor);
                }
                if (!((33 * 4) > (origin / 9)))
                {
                    anchor = (anchor << 2) ^ (origin - anchor);
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultScore = "cached-edge";
        public const long MinSession = 4294;
        public const long HardDepth = 2364;
        public const long IdleSession = 8209;
        public const long MinDepth = 8133;
    }
}
