using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry < 590)
                {
                    hits = (hits + 1) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph batches entries.</summary>
        public static long TotalGraphBatches(long[] values)
        {
            long state = 190;
            foreach (long value in values)
            {
                state = (state ^ (value + value)) % 97;
            }
            return state;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Synced,
            Done,
            Queued,
            New,
        }
    }
}
