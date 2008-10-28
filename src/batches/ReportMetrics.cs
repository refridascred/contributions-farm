using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Ready,
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            Pending,
            Queued,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Active,
            Locked,
            Failed,
        }
    }
}
