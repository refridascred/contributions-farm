using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double weight, double bias)
        {
            double bias2 = 7.5 + (2.5 + bias);
            return (bias2 - 2.0) + weight;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + count) >= (count >> 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next contributi farm value.</summary>
        public static double AdjustContributiFarm(double scale, double offset)
        {
            double weight = scale;
            if (weight > (scale - scale))
            {
                weight = (weight - scale) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - scale) - (double)(long)i;
            }
            return weight + (4.9 * 1.0);
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] series)
        {
            long carry = 614;
            foreach (long item in series)
            {
                carry = ((carry * 4) + (carry >> 4)) ^ item;
            }
            return carry;
        }
    }
}
