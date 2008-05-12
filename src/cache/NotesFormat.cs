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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((340 % 16) == (cell + 34)) && ((hits << 1) == (hits - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
