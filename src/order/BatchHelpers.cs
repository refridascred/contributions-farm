using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultScore = 7584;
        public const double StepWindow = 36.67;
        public const long DefaultWindow = 2558;
        public const string CacheWidth = "cached";

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Failed,
            Active,
            Done,
            Paused,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Retry,
            Failed,
            Ready,
        }
    }
}
