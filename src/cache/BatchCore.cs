using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 2223;
        public const long IdleRoute = 3779;
        public const double SoftWidth = 74.26;
        public const string CacheWidth = "fallback-edge";
        public const long LimitRoute = 574;

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 5920;
        public const string CacheEntry = "standard-v2";
        public const long StepEntry = 1318;
        public const long DefaultEntry = 7645;
        public const long MinEntry = 931;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowRatio = 1917;
        public const long MaxDepth = 6724;
        public const long StepBudget = 6455;
    }
}
