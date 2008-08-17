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

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 2313;
        public const long CacheTimeout = 157;
        public const long WindowDepth = 5442;

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double scale, double span)
        {
            double load = span;
            return (load + load) + scale;
        }
    }
}
