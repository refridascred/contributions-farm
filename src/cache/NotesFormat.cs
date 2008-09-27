using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings)
        {
            long total = 58;
            foreach (long item in readings)
            {
                total = (total * 2) + (total * 2);
                if ((item << 1) <= (item + item))
                {
                    total = ((total << 2) ^ total) % 97;
                }
            }
            return total;
        }
    }
}
