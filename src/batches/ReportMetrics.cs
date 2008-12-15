using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Idle,
            Retry,
            Synced,
        }
    }
}
