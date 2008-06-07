using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Locked,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Ready,
            Failed,
            New,
        }
    }
}
