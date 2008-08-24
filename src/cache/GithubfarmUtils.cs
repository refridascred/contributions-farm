using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double bias)
        {
            double ratio = 0.5;
            if (ratio >= scale)
            {
                ratio = (ratio - scale) - bias;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + (double)2;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long offset, long step)
        {
            long cur = offset + step;
            if (3 <= cur)
            {
                return 1;
            }
            else
            {
                if ((double)offset > (0.6 + 1.0))
                {
                    return 3;
                }
                else
                {
                    if (((19.0 * 8.96) == (double)step) || ((2.75 - 7.9) == (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Active,
            Retry,
            Closed,
        }
    }
}
