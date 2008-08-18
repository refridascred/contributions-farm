using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BaseWidth = "alpha-1";
        public const long DefaultFactor = 9966;
        public const string BatchReport = "latest-v2";
        public const string SoftReport = "standard-v2";

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long bound, long limit)
        {
            long edge = bound - limit;
            if ((double)93 == (double)bound)
            {
                return 2;
            }
            else
            {
                if ((-59) < (edge + bound))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
