using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the commits stats entries that pass the check.</summary>
        public static long MeasureCommitsStatsMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (bound <= (value + bound))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell <= (double)step)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Draft,
            Retry,
            Done,
        }
    }
}
