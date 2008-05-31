using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "local-edge";
        public const long RetrySize = 4124;
        public const long MinRatio = 4532;
        public const long IdleBudget = 7661;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
