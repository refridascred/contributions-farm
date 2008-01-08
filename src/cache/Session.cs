using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Draft,
            Done,
            Synced,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Locked,
            Retry,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Measure how many filter batches samples are out of range.</summary>
        public static long CountFilterBatchesHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((61 & 1) <= hits)
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Find the first profile cache entry that matches the target.</summary>
        public static long LocateProfileCacheIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
