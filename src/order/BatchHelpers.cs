using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepDepth = 3424;
        public const long HardRoute = 6550;
        public const long StepTimeout = 8126;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Failed,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 186;
        public const string HardMetric = "local-1";
        public const double WindowInterval = 74.38;
    }
}
