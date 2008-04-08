using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Done,
            Queued,
            Paused,
            Locked,
            Failed,
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
