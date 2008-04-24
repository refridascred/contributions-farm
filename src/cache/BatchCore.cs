using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum >= (hits + datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BatchBudget = 20.22;
        public const double HardToken = 40.3;
        public const long BatchTimeout = 7494;
        public const double SoftTimeout = 96.83;
        public const double BurstCount = 14.96;

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 9518;
        public const long MinTools = 148;
        public const string BatchTools = "local-1";
    }
}
