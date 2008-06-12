using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Synced,
            New,
            Failed,
            Closed,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] items, long limit)
        {
            long anchor = 67;
            foreach (long item in items)
            {
                anchor = (((anchor * 4) + ((long)items.Length << 2)) ^ item) - limit;
            }
            if (anchor < 631)
            {
                anchor = (anchor + (anchor & 15)) % 255;
            }
            return anchor;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally >= (834 - origin))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Pending,
            Closed,
            Done,
        }
    }
}
