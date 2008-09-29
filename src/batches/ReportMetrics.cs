using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 76.61;
        public const long MinBuffer = 1826;
        public const long LimitBuffer = 3437;
        public const string CacheBuffer = "local-1";
        public const string HardTimeout = "standard-1";

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
