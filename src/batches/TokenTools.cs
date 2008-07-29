using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 424;
        public const long DefaultDepth = 9613;
        public const long SoftEntry = 2646;
        public const long BatchEntry = 9741;
    }
}
