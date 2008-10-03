using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a layout farm pair into a bucket.</summary>
        public static long RankLayoutFarm(long origin, long seed)
        {
            long slot = origin ^ seed;
            if ((double)origin >= (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)origin < (16.0 * 2.3))
                {
                    return 8;
                }
                else
                {
                    if ((slot - origin) < (slot << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed * 2) <= (slot + origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many metrics support samples are out of range.</summary>
        public static long TallyMetricsSupportOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((4 % 16) != (cell + cell))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
