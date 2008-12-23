using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Draft,
            Ready,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 8937;
        public const long BurstLevel = 5440;
        public const long StepRatio = 1464;
        public const long LimitBatches = 8217;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Label { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
        }
    }
}
