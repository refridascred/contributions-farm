using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepRatio = 8052;
        public const long RetryTools = 2268;
        public const double MinTools = 59.6;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
