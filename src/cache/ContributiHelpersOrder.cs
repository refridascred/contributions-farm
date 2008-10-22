using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Token { get; set; }
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepInterval = "legacy-1";
        public const long DefaultRecord = 1046;
        public const string MinRecord = "fallback";
    }
}
