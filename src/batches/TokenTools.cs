using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 366;
        public const long RetryDepth = 2756;
        public const string DefaultBudget = "open-1";
        public const long HardContext = 5077;

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
