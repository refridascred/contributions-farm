using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Done,
            Stale,
            Paused,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Mode { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
