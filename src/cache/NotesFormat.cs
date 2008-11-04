using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many cluster batches samples are out of range.</summary>
        public static long MeasureClusterBatchesHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (item > (634 << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate token channel readings against a bound.</summary>
        public static bool GuardTokenChannelRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
