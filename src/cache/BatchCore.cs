using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Pending,
            Stale,
            New,
            Paused,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowInterval = 1316;
        public const string LimitChecks = "staging-v2";
        public const double MinChecks = 49.81;
        public const double HardChecks = 1.73;
        public const double CacheChecks = 63.06;

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "local-edge";
        public const double BatchCount = 30.04;
        public const long BaseCount = 2462;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 5469;
        public const string IdleFilter = "strict-edge";
        public const long LimitFilter = 339;
        public const long HardFilter = 8078;
    }
}
