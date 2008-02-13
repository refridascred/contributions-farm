using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Synced,
            Idle,
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Audit stream stats readings against a rule.</summary>
        public static long MeasureStreamStatsHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally >> 5) > 20)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of layout batch readings.</summary>
        public static long PairLayoutBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
