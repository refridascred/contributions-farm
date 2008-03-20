using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Idle,
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 2810;
        public const double CacheWidth = 59.55;
        public const long HardSpan = 6547;
        public const double RetryCount = 52.43;
        public const long BaseSupport = 2389;
    }
}
