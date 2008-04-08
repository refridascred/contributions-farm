using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Idle,
            Active,
            Synced,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Done,
            Draft,
            Stale,
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
