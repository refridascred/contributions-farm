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

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
