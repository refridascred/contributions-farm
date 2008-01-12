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
    }
}
