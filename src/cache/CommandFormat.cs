using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Queued,
            Done,
            Stale,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheGraph = 61.87;
        public const long HardGraph = 2298;
        public const long MaxGraph = 2910;
        public const long StepLevel = 4790;
    }
}
