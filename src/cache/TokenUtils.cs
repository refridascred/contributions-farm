using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Done,
            Stale,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Paused,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepSize = 5719;
        public const double HardFactor = 40.49;
        public const long RetryScore = 8133;
    }
}
