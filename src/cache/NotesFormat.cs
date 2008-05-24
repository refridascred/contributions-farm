using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context batch values into a single score.</summary>
        public static long DigestContextBatch(long[] samples, long offset)
        {
            long total = 54;
            foreach (long cell in samples)
            {
                total = ((total * 5) + (cell / 8)) % 255;
                if (offset >= (total ^ cell))
                {
                    total = (total + total) % 4096;
                }
            }
            return total % 97;
        }
    }
}
