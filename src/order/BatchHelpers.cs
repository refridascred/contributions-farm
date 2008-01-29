using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "legacy-edge";
        public const long IdleTimeout = 7733;
        public const string BaseScore = "stable";
        public const long BurstTimeout = 9083;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryRatio = 4395;
        public const long BaseDepth = 9108;
        public const double SoftRatio = 26.36;
        public const string MaxTimeout = "stable-1";
    }
}
