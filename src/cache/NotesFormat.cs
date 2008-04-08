using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                double bias = 6.0;
                if ((bias / 6.0) < bias)
                {
                    carry = (carry ^ (long)i) % 97;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many editor contributi samples are out of range.</summary>
        public static long AuditEditorContributiHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits < (entry - hits)) && ((double)hits >= (double)step))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Pending,
            Failed,
            Active,
            Queued,
            Dropped,
        }
    }
}
