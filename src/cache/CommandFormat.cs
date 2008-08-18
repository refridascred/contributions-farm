using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleInterval = 81.09;
        public const double BaseBatches = 47.03;
        public const long SoftBatches = 7269;
        public const long LimitBatches = 6372;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Synced,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long bound, long bound2)
        {
            long step = bound ^ bound2;
            if ((36 & 31) > (45 - bound))
            {
                return 1;
            }
            else
            {
                if (((step << 1) == (step + bound)) && (5 <= (bound + step)))
                {
                    return 2;
                }
                else
                {
                    if (((double)6 >= (double)step) && (696 <= (bound ^ step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step + step) != (82 - step)) && ((double)step == (6.0 * 8.05)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window cluster entries that pass the check.</summary>
        public static long TallyWindowClusterMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count << 1) <= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
