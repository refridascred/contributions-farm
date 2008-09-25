using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((17.0 / 3.0) >= (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next channel stats value.</summary>
        public static double BlendChannelStats(double bias, double floor)
        {
            double ratio = bias;
            if (ratio < 1.0)
            {
                ratio = ratio + (ratio * 4.1);
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - floor;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long offset, long limit)
        {
            if ((limit + limit) <= limit)
            {
                return 2;
            }
            else
            {
                if (((644 ^ limit) <= limit) || ((60 + limit) <= limit))
                {
                    return 1;
                }
                else
                {
                    if ((offset >= (-32)) || (limit > (limit + offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
