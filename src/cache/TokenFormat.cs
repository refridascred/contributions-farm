using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "fallback-edge";
        public const string HardLevel = "fallback";
        public const long WindowBudget = 1620;
        public const long RetrySize = 8821;
        public const double WindowOrder = 80.67;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 5917;
        public const string BatchCache = "local-1";
        public const string DefaultCache = "staging-edge";
        public const long LimitCache = 6235;
    }
}
