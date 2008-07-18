using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinScore = 6852;
        public const long HardStats = 505;
        public const string BatchCount = "legacy";
        public const long SoftStats = 8977;

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheLevel = 38.31;
        public const long IdleScore = 784;
        public const long BatchTimeout = 7507;
        public const string BaseBatches = "strict-edge";
        public const string BatchBatches = "local";

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardRatio = "staging-v2";
        public const string IdleBudget = "primary";
        public const long WindowFactor = 5660;
        public const long MinLayout = 1627;
    }
}
