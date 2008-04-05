using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstBudget = 5497;
        public const long HardRecord = 8256;
        public const long BaseBudget = 6921;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Stale,
            Done,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 9060;
        public const long MaxFarm = 7968;
        public const long SoftFarm = 3461;
        public const long RetryInterval = 7864;

        /// <summary>Define batch limits and defaults.</summary>
        public const double BatchFactor = 96.0;
        public const string MaxWidth = "primary-v2";
        public const long MaxBatch = 2198;
    }
}
