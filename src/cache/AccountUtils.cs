using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinSize = 5972;
        public const long MinContributi = 8834;
        public const long BatchScore = 275;

        /// <summary>Scale a tools route figure with a bias.</summary>
        public static double ProjectToolsRoute(double ratio, double span)
        {
            double bias = ratio * 9.2;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias - (double)43) - (double)(long)i) + span;
            }
            return bias + bias;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
