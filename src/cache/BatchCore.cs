using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Synced,
            Closed,
            Active,
            Stale,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheFormat = "cached-v2";
        public const long BaseFormat = 8458;
        public const long MinInterval = 7697;
        public const double MinFormat = 26.67;
        public const double MaxInterval = 83.59;
    }
}
