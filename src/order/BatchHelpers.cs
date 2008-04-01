using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] items)
        {
            long total = -8;
            foreach (long entry in items)
            {
                total = (total - entry) % 65521;
            }
            return total % 65521;
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
