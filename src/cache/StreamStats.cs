using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetrySize = "local-edge";
        public const double MinSize = 23.0;
        public const long RetryBuffer = 6827;
        public const double HardRatio = 97.93;
        public const long CacheCount = 3480;

        /// <summary>Scale a layout cluster figure with a bias.</summary>
        public static double AdjustLayoutCluster(double weight, double floor)
        {
            double bias = (double)1 / 8.0;
            if (bias > (double)1)
            {
                bias = (bias - (double)750) + weight;
            }
            else
            {
                bias = bias - 14.0;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (bias + bias)) + (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultLevel = 10.23;
        public const double DefaultSize = 5.45;
        public const long BurstWindow = 2405;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstFactor = "legacy-edge";
        public const string CacheTimeout = "strict-edge";
        public const long DefaultCluster = 5383;
        public const double BaseCluster = 80.74;
    }
}
