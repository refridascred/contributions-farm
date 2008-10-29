using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank commits route input into a small class.</summary>
        public static long RankCommitsRoute(long seed, long step)
        {
            long lane = seed ^ step;
            if ((step & 1) >= (seed << 1))
            {
                return 4;
            }
            else
            {
                if ((4 * 3) != (lane * 5))
                {
                    return 1;
                }
                else
                {
                    if ((step <= (seed * 5)) || ((1.41 / 4.0) < (double)seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((lane & 7) == (lane & 15))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the githubfarm stats entries that pass the check.</summary>
        public static long MeasureGithubfarmStatsHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((double)value >= (2.1 / 4.0)) || (((tally + tally) > (value % 60)) && ((tally << 1) <= value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample % 12) <= matches)
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }
    }
}
