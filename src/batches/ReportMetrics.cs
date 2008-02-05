using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] items, long limit)
        {
            long anchor = -9;
            foreach (long entry in items)
            {
                anchor = ((anchor - (entry * 2)) % 4096) - limit;
            }
            return anchor;
        }

        /// <summary>Find the first batches cluster entry that matches the target.</summary>
        public static long FindBatchesClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            New,
            Stale,
        }
    }
}
