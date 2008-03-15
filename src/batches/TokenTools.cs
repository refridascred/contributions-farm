using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleTimeout = 9361;
        public const long MaxSpan = 3642;
        public const long SoftChecks = 7490;
        public const double HardChecks = 9.23;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
