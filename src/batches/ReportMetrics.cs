using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Synced,
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Dropped,
            Pending,
        }
    }
}
