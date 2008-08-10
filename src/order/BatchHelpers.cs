using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long offset, long step)
        {
            if ((3.3 * 9.0) >= (double)offset)
            {
                return 4;
            }
            else
            {
                if (offset <= ((-551) - offset))
                {
                    return 6;
                }
                else
                {
                    if (step >= (867 & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((52 << 3) >= (datum ^ datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
