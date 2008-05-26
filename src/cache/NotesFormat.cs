using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the metric notes entries that pass the check.</summary>
        public static long MeasureMetricNotesHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item - hits) > (0 ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((33 - matches) > (matches + 2))
                {
                    matches = ((matches + 1) + reading) - step;
                }
            }
            return matches;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
