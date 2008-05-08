using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Count { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 2496;
        public const long BurstFactor = 7739;
        public const string HardWindow = "fallback-1";

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 9561;
        public const string IdleBatches = "strict-1";
        public const double MaxBatches = 58.1;
    }
}
