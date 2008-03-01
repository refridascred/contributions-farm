using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Synced,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Active,
            Stale,
            Dropped,
            Failed,
        }

        /// <summary>Measure how many schema batches samples are out of range.</summary>
        public static long AuditSchemaBatchesOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((target % 60) >= (hits << 2))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
