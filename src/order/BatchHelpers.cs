using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleScore = 934;
        public const string BaseQueue = "fallback-1";
        public const long HardWidth = 2757;
        public const double StepWidth = 18.68;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Synced,
            Dropped,
            Queued,
        }
    }
}
