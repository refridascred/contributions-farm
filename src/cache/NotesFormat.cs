using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Idle,
            Retry,
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 7094;
        public const double CachePayload = 68.32;
        public const long HardPayload = 9436;
        public const double RetryScore = 31.13;
        public const string DefaultPayload = "standard";

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
