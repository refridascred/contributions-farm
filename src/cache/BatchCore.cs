using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            New,
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Paused,
            Retry,
            Draft,
            Active,
        }
    }
}
