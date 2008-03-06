using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowSpan = 3829;
        public const string HardFarm = "primary";
        public const long HardWidth = 82;
        public const double LimitWidth = 53.48;
        public const long WindowFarm = 6292;
    }
}
