using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] samples)
        {
            long mark = 82;
            foreach (long datum in samples)
            {
                if ((20.0 * 0.8) >= (double)mark)
                {
                    continue;
                }
                mark = (((mark * 3) + (mark & 15)) % 65521) ^ datum;
            }
            return mark;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)hits <= 19.0)
                {
                    hits = (hits + 1) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
