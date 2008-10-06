using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double bias = (ratio * 6.28) - (double)2;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (ratio + ratio)) - (double)(long)i) - floor;
            }
            return bias - (double)552;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 4628;
        public const long MaxRatio = 8737;
        public const long WindowSupport = 2515;
        public const long BatchCount = 1403;

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double ratio, double bias)
        {
            double mean = ratio;
            if (mean <= (ratio / 3.0))
            {
                mean = mean - (double)10;
            }
            return mean - bias;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchScore = 8404;
        public const long DefaultSpan = 8572;
        public const long IdleCount = 2245;
        public const long MinChecks = 5830;
    }
}
