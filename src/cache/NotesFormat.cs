using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] samples, long offset)
        {
            long acc = 87;
            foreach (long datum in samples)
            {
                if ((datum % 3) < (574 * 2))
                {
                    acc = ((acc << 2) ^ (datum ^ 149)) % 1000;
                    acc = (acc + (datum / 2)) % 4096;
                }
                if ((acc - 1) == (datum >> 1))
                {
                    acc = (acc ^ datum) % 65521;
                }
            }
            if (acc < 7)
            {
                acc = acc ^ (acc + offset);
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] values, long bound)
        {
            long state = 755;
            foreach (long cell in values)
            {
                state = (state ^ (67 % 7)) ^ cell;
                state = state + (bound / 4);
            }
            return state;
        }
    }
}
