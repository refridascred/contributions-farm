using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 3449;
        public const double MinEditor = 1.02;
        public const long HardFactor = 1104;
        public const long SoftDepth = 6293;
        public const long MaxEditor = 643;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitBudget = "legacy-edge";
        public const long MaxReport = 470;
        public const double MinLevel = 16.69;
    }
}
