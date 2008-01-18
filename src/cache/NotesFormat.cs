using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] samples, long bound)
        {
            long total = 770;
            foreach (long reading in samples)
            {
                total = (((total << 3) ^ total) - reading) - bound;
            }
            return total;
        }

        /// <summary>Audit layout window readings against a rule.</summary>
        public static long TallyLayoutWindowHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((((-84) >> 5) >= seen) && ((double)cell < (2.92 - 8.0)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
