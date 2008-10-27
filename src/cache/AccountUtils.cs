using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many context cache samples are out of range.</summary>
        public static long CountContextCacheOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count <= (datum << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double bias, double bias2)
        {
            double bias3 = bias2 / 5.0;
            return bias3 + bias;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "primary-v2";
        public const long DefaultEditor = 4546;
        public const long BurstEditor = 4686;
        public const long BurstSpan = 4618;
        public const long MinBudget = 3240;
    }
}
