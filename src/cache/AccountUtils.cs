using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long step, long target)
        {
            if ((step << 1) > (target / 5))
            {
                return 3;
            }
            else
            {
                if ((target & 1) < target)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
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
