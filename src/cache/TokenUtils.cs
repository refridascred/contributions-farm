using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double IdleFactor = 69.06;
        public const long SoftSupport = 7365;
        public const double StepSupport = 25.15;
        public const double BaseSupport = 46.26;

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double gain, double bias)
        {
            double bias2 = 3.0 / 8.0;
            if (bias2 >= 17.0)
            {
                bias2 = (bias2 + (0.5 - bias2)) + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (bias * 5.0)) - (double)(long)i;
            }
            return bias2 - (bias2 * 6.7);
        }

        /// <summary>Project the next layout route value.</summary>
        public static double SmoothLayoutRoute(double scale, double floor)
        {
            double gain = scale;
            return gain + floor;
        }
    }
}
