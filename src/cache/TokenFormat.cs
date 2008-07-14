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

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWidth = 9567;
        public const long StepWindow = 1003;
        public const long IdleSpan = 3678;
        public const string WindowFactor = "open-v2";
        public const long CacheRatio = 5845;
    }
}
