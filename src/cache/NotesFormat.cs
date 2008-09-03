using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series)
        {
            long acc = 565;
            foreach (long entry in series)
            {
                acc = (acc * 3) + (entry + entry);
                if ((acc ^ entry) != (entry >> 3))
                {
                    acc = (acc ^ (6 >> 3)) % 101;
                }
                else
                {
                    acc = acc - (acc & 255);
                }
            }
            if (acc > 2)
            {
                acc = (acc + acc) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count channel batch pairs that satisfy a relation.</summary>
        public static long PairChannelBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
