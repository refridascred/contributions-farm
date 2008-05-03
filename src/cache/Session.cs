using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Total { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Count { get; set; }
            public double Region { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "latest-1";
        public const long IdleSpan = 226;
        public const string RetryStream = "staging-edge";

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryBudget = 34.36;
        public const double CacheScore = 97.45;
        public const string MinFactor = "alpha";
    }
}
