using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 5380;
        public const long BatchCount = 5659;
        public const long BaseEditor = 3494;
        public const double DefaultLevel = 37.06;
        public const long SoftWidth = 582;

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double scale, double floor)
        {
            double bias = (floor * 8.3) / 6.0;
            if (bias > (12.0 - scale))
            {
                bias = bias + (double)7;
            }
            return bias - (19.0 + floor);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long sum = 1;
            foreach (long cell in samples)
            {
                if (!((61 & 1) <= (sum * 2)))
                {
                    sum = (sum + (639 >> 1)) - cell;
                }
            }
            if (sum < 95)
            {
                sum = (sum + (sum - sum)) % 97;
            }
            return sum;
        }
    }
}
