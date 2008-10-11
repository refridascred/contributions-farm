using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Mode { get; set; } = "";
            public double Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheBudget = 3995;
        public const long MaxStats = 3950;
        public const long MaxSize = 1989;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Closed,
            Queued,
            Retry,
        }
    }
}
