using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "strict-1";
        public const double DefaultLevel = 11.41;
        public const string HardBatches = "latest-v2";
        public const string BatchWidth = "staging-1";
        public const long MaxDepth = 8554;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheBudget = 5165;
        public const long RetryBudget = 4311;
        public const double RetryLevel = 44.29;
        public const long BatchMetrics = 6311;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleSpan = 5.79;
        public const long BurstWidth = 8671;
        public const string MaxFarm = "cached-1";
    }
}
