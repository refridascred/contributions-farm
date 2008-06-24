using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 4347;
        public const string MinScore = "cached";
        public const long MinCount = 1468;
        public const string MinBatches = "staging";
        public const long MaxBatches = 4830;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Locked,
            Ready,
            Queued,
        }
    }
}
