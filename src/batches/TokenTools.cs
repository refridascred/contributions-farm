using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryTimeout = 3010;
        public const string IdleFactor = "open-edge";
        public const long DefaultBatches = 9183;
        public const long BatchWidth = 4599;
        public const double MaxBatches = 93.25;
    }
}
