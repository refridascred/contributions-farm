using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 7388;
        public const string DefaultCount = "open-v2";
        public const long RetryQueue = 2312;
    }
}
