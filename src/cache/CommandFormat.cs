using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
