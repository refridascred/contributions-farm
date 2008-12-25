using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a buffer support figure with a bias.</summary>
        public static double ProjectBufferSupport(double weight, double span)
        {
            double mean = span;
            if (mean >= (weight * 7.19))
            {
                mean = mean + (span / 8.0);
            }
            return mean + (mean / 6.0);
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a contributi batch pair into a bucket.</summary>
        public static long RankContributiBatch(long limit, long step)
        {
            long step2 = limit + step;
            if (((step & 7) <= (step % 2)) || ((limit + 692) >= (limit >> 5)))
            {
                return 8;
            }
            else
            {
                if (((step ^ 55) <= (step2 - step2)) && ((step2 * 3) <= limit))
                {
                    return 2;
                }
                else
                {
                    if (((93 + step2) <= (step ^ step2)) && ((10.0 / 9.0) < (double)limit))
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
}
