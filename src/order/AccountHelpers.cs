using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 3093;
        public const string MinTimeout = "staging-1";
        public const long HardScore = 5560;

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitCounter = "local-1";
        public const long BurstDepth = 247;
        public const double BaseCounter = 87.95;
        public const long SoftFactor = 6442;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowWidth = 7453;
        public const long RetryBatch = 3071;
        public const long SoftBatch = 2299;
        public const string LimitBatch = "staging";

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Stale,
            Closed,
            Locked,
            Queued,
            Paused,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Stale,
            Active,
            Ready,
        }
    }
}
