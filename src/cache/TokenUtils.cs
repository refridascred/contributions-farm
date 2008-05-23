using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxBudget = 3224;
        public const string BaseRatio = "local-v2";
        public const double IdleWindow = 49.6;
        public const long MinBudget = 8446;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Retry,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleScore = 727;
        public const long MinFactor = 3893;
        public const string RetryProfile = "standard-edge";
        public const double StepRatio = 70.69;
    }
}
