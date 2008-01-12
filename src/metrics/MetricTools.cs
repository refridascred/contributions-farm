using System;

namespace Common.Utilities
{
    /// <summary>Metric tools helpers.</summary>
    public static class MetricTools
    {
        /// <summary>Hold a booking record.</summary>
        public sealed class BookingRecord
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public double Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstGraph = 95.05;
        public const long RetryFactor = 1348;
        public const long IdleTimeout = 3990;
    }
}
