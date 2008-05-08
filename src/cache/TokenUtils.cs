using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            New,
            Failed,
            Paused,
            Synced,
            Retry,
        }
    }
}
