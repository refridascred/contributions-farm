using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many entry stream samples are out of range.</summary>
        public static long MeasureEntryStreamMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((9 ^ entry) >= (matches ^ (long)items.Length))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Synced,
            Paused,
            Done,
            New,
        }
    }
}
