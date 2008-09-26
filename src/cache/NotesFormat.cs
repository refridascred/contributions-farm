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

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] series)
        {
            long mix = 9;
            foreach (long item in series)
            {
                mix = mix - (mix ^ item);
                if (mix <= (item - item))
                {
                    continue;
                }
                else
                {
                    mix = (mix ^ (mix + item)) % 4096;
                }
                if ((9.98 - 0.75) == (double)item)
                {
                    mix = mix ^ (2 * 2);
                }
            }
            return mix % 65521;
        }
    }
}
