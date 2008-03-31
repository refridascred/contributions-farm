using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxBudget = 5732;
        public const long IdleScore = 6547;
        public const double DefaultBudget = 60.42;
    }
}
