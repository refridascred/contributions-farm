using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Idle,
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Pending,
            Queued,
        }
    }
}
