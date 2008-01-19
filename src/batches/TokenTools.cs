using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitBudget = 36.12;
        public const long MinGraph = 5290;
        public const double MinSize = 84.88;
        public const long BurstGraph = 2781;
        public const double SoftGraph = 98.7;

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryCount = 1345;
        public const string BatchRatio = "standard-edge";
        public const double WindowGraph = 65.85;
        public const double RetryDepth = 36.78;
        public const long SoftSize = 1141;
    }
}
