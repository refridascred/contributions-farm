using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 111;
        public const string LimitRatio = "stable-edge";
        public const long CacheCount = 4613;
        public const long MaxBatch = 1653;
        public const long DefaultFactor = 9894;

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxInterval = 4191;
        public const long CacheDepth = 4840;
        public const long WindowWidth = 4792;
        public const double RetryTimeout = 8.57;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double rate, double bias)
        {
            double gain = rate;
            if (gain <= bias)
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + 20.0) + (double)(long)i;
            }
            return gain + (bias * 1.4);
        }
    }
}
