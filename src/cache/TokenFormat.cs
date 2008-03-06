using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Synced,
            Locked,
            Failed,
            Idle,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 87.25;
        public const long RetryScore = 2685;
        public const long DefaultInterval = 7131;
        public const double HardContributi = 33.19;
        public const string DefaultContributi = "standard";

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
