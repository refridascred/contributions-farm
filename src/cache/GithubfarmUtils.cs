using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] levels, long target)
        {
            long carry = -2;
            foreach (long item in levels)
            {
                if ((carry + item) > (item + carry))
                {
                    carry = (carry - target) % 97;
                }
            }
            return carry;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double ratio, double bias)
        {
            double ratio2 = (bias * 3.63) + bias;
            return (ratio2 + (ratio2 + bias)) + ratio;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > (sample - sample))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
