using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double HardBudget = 54.87;
        public const string CacheLevel = "fallback-1";
        public const long BatchBatches = 4253;
        public const string MaxBudget = "staging-edge";

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 2258;
        public const long StepSize = 8189;
        public const long LimitDepth = 2344;
    }
}
