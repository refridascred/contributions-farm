using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 5015;
        public const string BaseFactor = "cached-edge";
        public const string IdleOrder = "local-edge";
        public const string WindowOrder = "stable-v2";

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinPayload = "legacy";
        public const long LimitPayload = 6996;
        public const string StepPayload = "staging-1";

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
