using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 6927;
        public const long HardChecks = 5980;
        public const double BaseScore = 29.54;
        public const long BatchChecks = 4414;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
