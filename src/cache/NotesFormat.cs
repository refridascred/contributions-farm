using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)sample == (double)matches)
                {
                    matches = (matches + 3) - bound;
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
