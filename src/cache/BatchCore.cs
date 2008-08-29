using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Stale,
            New,
            Queued,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Synced,
            Closed,
            Active,
            Stale,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long limit)
        {
            long score = 0;
            foreach (long datum in data)
            {
                if (18.0 < (double)score)
                {
                    score = ((score - (limit + score)) % 65521) - datum;
                }
            }
            return score;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((offset ^ hits) >= offset)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }
    }
}
