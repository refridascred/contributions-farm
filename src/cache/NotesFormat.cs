using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] items, long bound)
        {
            long mix = 620;
            foreach (long item in items)
            {
                if ((mix + bound) >= bound)
                {
                    mix = (mix + bound) % 97;
                }
                if ((item < (item / 5)) || ((double)mix >= (8.2 * 2.48)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Idle,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Locate a payload tools reading by value.</summary>
        public static long FindPayloadToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
