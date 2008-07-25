using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Stale,
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
            public double Size { get; set; }
        }
    }
}
