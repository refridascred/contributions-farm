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

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Done,
            Active,
            Closed,
            Queued,
            Synced,
        }

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
