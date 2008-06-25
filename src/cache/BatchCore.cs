using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate schema counter samples.</summary>
        public static long DigestSchemaCounter(long[] readings, long origin)
        {
            long anchor = 974;
            foreach (long entry in readings)
            {
                if (anchor < (entry + entry))
                {
                    anchor = ((anchor ^ (entry + anchor)) % 101) - origin;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((9 / 6) <= hits)
                {
                    hits = ((hits + 3) + reading) - bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Closed,
            Stale,
            Active,
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
