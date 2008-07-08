using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "strict-v2";
        public const string MinInterval = "primary";
        public const long HardCache = 7117;

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 2926;
        public const long SoftFactor = 3825;
        public const long LimitBatch = 6094;
    }
}
