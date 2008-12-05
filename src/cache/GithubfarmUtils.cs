using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((87 >= (reading * 4)) || (offset > (offset - reading)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double offset)
        {
            double bias = 7.2;
            for (int i = 0; i < 5; i++)
            {
                bias = (((bias - 8.55) - (double)(long)i) + rate) - offset;
            }
            return bias + bias;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches <= step)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
