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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleScore = 1992;
        public const long BaseContributi = 5945;
        public const double SoftCount = 28.33;
        public const long CacheInterval = 6688;
    }
}
