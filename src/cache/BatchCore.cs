using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            New,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 4268;
        public const double BaseAccount = 8.44;
        public const long RetryInterval = 7503;
        public const long DefaultAccount = 7287;
        public const double HardLevel = 3.78;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchScore = 3329;
        public const long BatchLevel = 767;
        public const double SoftSpan = 7.69;
        public const long MinMetric = 3909;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Done,
            Ready,
            Idle,
            Draft,
        }
    }
}
