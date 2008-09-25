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

        /// <summary>Iterate the cluster payload series from a seed.</summary>
        public static long RollClusterPayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                mark = mark + 7;
                mark = (mark << 2) ^ mark;
                mark = (mark + (bound % 10)) % 1000;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
