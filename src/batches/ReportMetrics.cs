using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Synced,
            Pending,
            New,
            Paused,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
