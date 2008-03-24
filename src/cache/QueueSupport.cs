using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string SoftWidth = "fallback";
        public const long MinLevel = 9343;
        public const long SoftContext = 6975;

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitSpan = "staging-v2";
        public const string CacheCommits = "primary";
        public const long RetryCommits = 7400;

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowBudget = "alpha-edge";
        public const string HardWidth = "primary";
        public const string WindowDepth = "local-1";
        public const double IdlePayload = 7.9;
    }
}
