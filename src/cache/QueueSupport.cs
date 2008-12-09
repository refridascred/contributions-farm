using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double weight = floor - floor;
            return (weight + (double)713) + ratio;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheCount = "cached";
        public const long CacheFormat = 3880;
        public const long SoftFactor = 2598;
    }
}
