using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "legacy-edge";
        public const long MinGraph = 6127;
        public const long BatchGraph = 6893;
        public const string DefaultCount = "staging-1";

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitScore = 187;
        public const long RetrySession = 7471;
        public const long RetryLevel = 5071;
    }
}
