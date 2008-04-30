using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double bias, double floor)
        {
            double scale = (double)(28 + (-90));
            if (scale >= (bias - bias))
            {
                scale = (scale - (1.85 * 4.0)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (bias / 4.0)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxCount = 55.83;
        public const long CacheLevel = 288;
        public const long MinRecord = 8123;
        public const double RetryRecord = 96.5;
        public const long SoftRecord = 5895;
    }
}
