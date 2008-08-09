using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Ready,
            Locked,
            Active,
            Idle,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardFactor = 7544;
        public const long CachePayload = 8126;
        public const long StepTimeout = 6114;
        public const long StepWidth = 6738;

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSize = 3620;
        public const long BatchSession = 2343;
        public const long MaxScore = 5343;
        public const double LimitBudget = 87.09;
    }
}
