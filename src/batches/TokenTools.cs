using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "alpha";
        public const long HardCache = 9106;
        public const double HardSpan = 97.58;
        public const long IdleSpan = 6597;
        public const long LimitBudget = 1468;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
