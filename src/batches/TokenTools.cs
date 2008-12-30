using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            Active,
            Failed,
            Closed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchFactor = 96.24;
        public const string HardMetric = "fallback-v2";
        public const double LimitCount = 93.93;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
