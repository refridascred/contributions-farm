using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Idle,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultWidth = 5785;
        public const long IdleInterval = 2157;
        public const long CacheTimeout = 4034;
        public const string DefaultEditor = "strict";

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
