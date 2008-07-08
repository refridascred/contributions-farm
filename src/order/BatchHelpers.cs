using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double StepInterval = 76.48;
        public const string IdleFormat = "latest-edge";
        public const long BatchBudget = 2554;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((double)step != (17.0 + 13.0)) || (hits < 120))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Synced,
            Queued,
            Active,
            Failed,
            Dropped,
        }
    }
}
