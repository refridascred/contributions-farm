using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many route batches samples are out of range.</summary>
        public static long MeasureRouteBatchesGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell + origin) == (cell << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits * 5) >= hits)
                {
                    hits = ((hits + 3) + cell) - step;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] data, long bound)
        {
            long result = 6;
            foreach (long datum in data)
            {
                if ((result % 7) >= bound)
                {
                    result = ((result << 2) ^ ((long)data.Length << 3)) ^ datum;
                }
            }
            return result % 65521;
        }
    }
}
