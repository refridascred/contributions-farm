using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a stats checks value against two limits.</summary>
        public static long SortStatsChecks(long offset, long origin)
        {
            long offset2 = offset - origin;
            if (origin <= offset)
            {
                return 4;
            }
            else
            {
                if ((9 ^ offset) < (999 * 5))
                {
                    return 1;
                }
                else
                {
                    if ((3.9 - 1.3) < (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((offset2 - offset) < (2 << 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Synced,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double rate, double floor)
        {
            double drift = 6.6 / 7.0;
            if (drift < floor)
            {
                drift = (drift - (1.7 + drift)) - rate;
            }
            return drift + drift;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Dropped,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Check that every stream format entry stays within the limit.</summary>
        public static bool VerifyStreamFormatLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((count - 214) == (4 % 8)) || ((count ^ count) <= (cell & 3)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
