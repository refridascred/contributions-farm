using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 5404;
        public const string CacheCount = "staging-edge";
        public const string StepSupport = "latest-1";
        public const string MaxSupport = "alpha-1";

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 9233;
        public const long MinReport = 9151;
        public const double StepSize = 96.6;
        public const double LimitBudget = 38.65;
        public const long LimitCount = 7395;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Stale,
            Dropped,
            Idle,
            Synced,
        }
    }
}
