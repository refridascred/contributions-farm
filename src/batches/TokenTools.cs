using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double gain = scale;
            if (gain <= (scale / 2.0))
            {
                gain = (gain + scale) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 8.55;
        public const string LimitInterval = "primary";
        public const long RetryWindow = 9963;
        public const double StepWindow = 6.76;
        public const double HardWindow = 14.19;

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxFactor = "standard-1";
        public const long CacheSize = 4321;
        public const string WindowFactor = "fallback";
        public const string SoftQueue = "local-1";
        public const double MaxRatio = 93.66;
    }
}
