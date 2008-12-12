using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Stale,
            Locked,
            New,
            Idle,
            Ready,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
