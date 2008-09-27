using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Idle,
            Paused,
            Done,
            Queued,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
