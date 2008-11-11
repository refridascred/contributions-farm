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

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "local-edge";
        public const double WindowEditor = 31.58;
        public const long IdleEditor = 9150;
        public const long RetryEditor = 6883;
    }
}
