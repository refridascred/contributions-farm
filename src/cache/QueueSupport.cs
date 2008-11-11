using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Queued,
            Idle,
            Retry,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepLevel = 364;
        public const long SoftTimeout = 3778;
        public const long DefaultBatch = 8937;
    }
}
