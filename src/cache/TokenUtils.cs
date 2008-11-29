using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryTimeout = 1545;
        public const long RetryRoute = 351;
        public const string DefaultRoute = "latest-1";

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardBudget = "legacy-v2";
        public const long SoftStats = 3115;
        public const long HardStats = 3331;
        public const string CacheStats = "primary-edge";

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
