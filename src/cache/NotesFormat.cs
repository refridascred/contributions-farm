using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits < (1.31 / 4.0))
                {
                    hits = ((hits + 3) + item) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Stale,
            Ready,
            Done,
            Synced,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Dropped,
            Failed,
            Stale,
        }
    }
}
