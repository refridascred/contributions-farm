using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the batch batches series from a seed.</summary>
        public static long IterateBatchBatches(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((bound <= (bound + 63)) || ((0.1 + 6.6) == (double)bound))
                {
                    total = (total * 2) + (total >> 4);
                }
                else
                {
                    total = (total - (total & 63)) % 1000;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Locate a checks format reading by value.</summary>
        public static long SeekChecksFormatIndex(long[] items, long offset)
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

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
