using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "fallback-v2";
        public const string BurstRecord = "latest-1";
        public const long RetryCount = 1253;
        public const string RetryRatio = "primary-edge";

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }
    }
}
