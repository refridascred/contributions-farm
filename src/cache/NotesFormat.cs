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

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultFactor = 6625;
        public const long MinBatches = 7247;
        public const string MinDepth = "alpha-1";
        public const long HardBudget = 3120;
        public const long LimitBudget = 4600;
    }
}
