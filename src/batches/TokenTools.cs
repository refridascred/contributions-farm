using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 44.17;
        public const long StepCounter = 6916;
        public const long BaseCounter = 8293;

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinCount = 5967;
        public const long MaxMetric = 4867;
        public const long StepMetric = 1433;
        public const long IdleFactor = 6259;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
