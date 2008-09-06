using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Retry,
            New,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Active,
            Stale,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
