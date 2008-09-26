using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double gain, double offset)
        {
            double bias = (double)(7 - 0);
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + (7.91 - bias)) + (double)(long)i) - gain;
            }
            return bias + offset;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardBudget = "primary-v2";
        public const double MaxBudget = 39.07;
        public const double SoftSize = 37.1;
        public const double BatchSupport = 13.97;
        public const long HardRatio = 945;

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] items)
        {
            long total = 482;
            foreach (long item in items)
            {
                if (((long)items.Length >> 2) > (item + total))
                {
                    total = (total << 2) ^ (482 >> 4);
                }
                else
                {
                    total = (total - (total % 5)) % 1000;
                }
                if ((total >= (total + total)) || ((double)total > (4.4 * 9.4)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long seed, long seed2)
        {
            if ((double)seed < (4.6 * 5.7))
            {
                return 6;
            }
            else
            {
                if ((3.3 + 2.7) >= (double)seed2)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
