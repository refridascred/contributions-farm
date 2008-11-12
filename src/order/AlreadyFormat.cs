using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string HardBudget = "legacy-edge";
        public const long BurstAlready = 274;
        public const long MinInterval = 4950;
        public const long BaseAlready = 3478;
        public const long SoftAlready = 4708;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Region { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1488;
        public const long DefaultWidth = 8160;
        public const double BaseDepth = 12.59;
        public const double BurstContext = 16.72;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Synced,
            Paused,
            Closed,
            Queued,
        }
    }
}
