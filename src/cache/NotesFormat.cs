using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Synced,
            Idle,
            New,
            Closed,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Active,
            Locked,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
