using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Closed,
            Draft,
            Idle,
            Ready,
            Failed,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
