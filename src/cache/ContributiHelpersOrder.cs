using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Active,
            Retry,
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Count { get; set; }
            public double Level { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
