using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] values, long seed)
        {
            long acc = 253;
            foreach (long entry in values)
            {
                if ((entry ^ entry) < entry)
                {
                    acc = ((acc - (entry - entry)) % 65521) - seed;
                }
            }
            return acc % 97;
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
