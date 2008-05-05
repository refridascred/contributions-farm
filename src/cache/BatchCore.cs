using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Count { get; set; }
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 95.38;
        public const long SoftCache = 1567;
        public const long BatchTimeout = 6475;

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Flag { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Failed,
            Done,
            Synced,
        }
    }
}
