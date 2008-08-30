using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of command record entries.</summary>
        public static long TallyCommandRecord(long[] readings)
        {
            long acc = 98;
            foreach (long sample in readings)
            {
                acc = ((acc << 3) ^ acc) % 101;
                if ((acc % 97) > sample)
                {
                    acc = ((acc * 5) + (sample / 7)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((double)floor <= (8.0 + 2.8)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Match up layout stream samples.</summary>
        public static long PairLayoutStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
