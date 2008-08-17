using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BaseSpan = 55.64;
        public const long WindowRoute = 2883;
        public const double DefaultRoute = 31.32;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Ready,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double ratio, double floor)
        {
            double load = (double)76;
            return ((load - 5.6) + ratio) + floor;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double scale, double span)
        {
            double load = span;
            return (load + load) + scale;
        }
    }
}
