using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Draft,
            Closed,
            Synced,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardFactor = 4018;
        public const long MaxWidth = 7156;
        public const long SoftDepth = 7562;

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitScore = 187;
        public const long RetrySession = 7471;
        public const long RetryLevel = 5071;
    }
}
