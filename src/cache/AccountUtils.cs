using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a stats window pair into a bucket.</summary>
        public static long RankStatsWindow(long offset, long bound)
        {
            if ((offset & 7) > bound)
            {
                return 8;
            }
            else
            {
                if ((double)bound == (6.9 / 4.0))
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) < (bound - (-39)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long step, long seed)
        {
            long bound = step - seed;
            if ((step + step) != (bound << 1))
            {
                return 7;
            }
            else
            {
                if ((step * 3) <= seed)
                {
                    return 4;
                }
                else
                {
                    if ((step + 901) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item - tally) <= (tally << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
