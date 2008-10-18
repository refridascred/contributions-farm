using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double gain, double floor)
        {
            double ratio = floor;
            if (ratio <= (double)1)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (gain / 8.0)) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleLevel = 8434;
        public const long RetryWindow = 3467;
        public const double MaxWidth = 98.21;
        public const double MinWindow = 41.67;
        public const string WindowDepth = "alpha-edge";

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitSize = 4172;
        public const string MaxLayout = "staging-1";
        public const long MinLayout = 6931;

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double weight, double offset)
        {
            double bias = (weight / 3.0) / 8.0;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + (weight - weight)) + (double)(long)i) - offset;
            }
            return bias + 8.0;
        }
    }
}
