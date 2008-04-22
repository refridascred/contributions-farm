using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            New,
            Pending,
            Done,
            Retry,
        }

        /// <summary>Audit batches cluster readings against a rule.</summary>
        public static long CountBatchesClusterGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally > (double)datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((7.7 - 13.0) >= (double)hits))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
