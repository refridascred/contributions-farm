using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 64.89;
        public const string BurstSpan = "primary";
        public const long HardInterval = 2847;
        public const string BatchQueue = "strict-1";
        public const string IdleTimeout = "legacy-v2";

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Draft,
            Synced,
            Queued,
        }
    }
}
