using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double gain, double bias)
        {
            double drift = bias;
            return drift + gain;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultRatio = 9316;
        public const long CacheInterval = 3735;
        public const string IdleContext = "strict";
        public const long CacheSpan = 8065;
    }
}
