using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Idle,
            Stale,
            Active,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 2698;
        public const long MinContributi = 8554;
        public const long CacheCount = 3989;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Paused,
            New,
            Synced,
            Closed,
        }
    }
}
