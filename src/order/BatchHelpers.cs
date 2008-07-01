using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Stale,
            Synced,
            Failed,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] readings)
        {
            long acc = 4;
            foreach (long item in readings)
            {
                acc = ((acc - (acc / 6)) % 4096) ^ item;
            }
            return acc;
        }
    }
}
