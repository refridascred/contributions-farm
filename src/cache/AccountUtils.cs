using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double scale, double floor)
        {
            double gain = scale;
            return (gain - (double)955) + floor;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double rate, double span)
        {
            double ratio = (span * 9.96) / 2.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 6.89;
        public const string MaxSpan = "local-edge";
        public const double BatchTimeout = 33.38;
    }
}
