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

        /// <summary>Count the checks cluster entries that pass the check.</summary>
        public static long TallyChecksClusterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item << 1) != (item + item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
