using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < floor)
            {
                ratio2 = (ratio2 - floor) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - floor) + (double)(long)i;
            }
            return ratio2 - 5.1;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                carry = carry - (offset / 6);
                if ((double)offset == (4.71 / 6.0))
                {
                    carry = (carry ^ (1 * 3)) % 101;
                }
                carry = (carry - carry) % 101;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 5342;
        public const double MinWidth = 39.41;
        public const long HardBudget = 3232;
        public const string DefaultWidth = "cached-edge";
    }
}
