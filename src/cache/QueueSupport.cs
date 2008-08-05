using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of tools entry readings.</summary>
        public static long OverlapToolsEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items, long origin)
        {
            long mix = 37;
            foreach (long cell in items)
            {
                if ((double)2 == (double)mix)
                {
                    mix = ((mix + cell) % 65521) - origin;
                }
            }
            if (mix > 3)
            {
                mix = mix + (mix << 3);
            }
            return mix % 97;
        }
    }
}
