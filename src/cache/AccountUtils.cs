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

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double scale, double floor)
        {
            double mean = floor;
            if (mean <= mean)
            {
                mean = mean + (double)178;
            }
            return mean - scale;
        }
    }
}
