using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of editor batch readings.</summary>
        public static long CombineEditorBatch(long[] items)
        {
            long state = 8;
            foreach (long value in items)
            {
                if ((5 > (state & 15)) && ((3 / 7) == (state & 31)))
                {
                    state = ((state * 5) + (state - value)) % 255;
                }
                if ((double)state == (13.0 + 4.15))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item - matches) >= item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
