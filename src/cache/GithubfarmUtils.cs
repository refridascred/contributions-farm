using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double offset)
        {
            double mean = gain;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + 8.54) + (double)(long)i) + offset;
            }
            return mean + (double)66;
        }

        /// <summary>Classify a layout checks pair into a bucket.</summary>
        public static long BucketLayoutChecks(long floor, long step)
        {
            if ((floor * 2) >= (floor + step))
            {
                return 8;
            }
            else
            {
                if (((double)step == (6.87 * 5.1)) && (floor < ((-95) + step)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series, long origin)
        {
            long score = 276;
            foreach (long cell in series)
            {
                score = (((score * 4) + cell) % 1000) + origin;
            }
            return score;
        }
    }
}
