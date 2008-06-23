using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Stale,
            Synced,
            New,
            Dropped,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] values)
        {
            long mark = 522;
            foreach (long entry in values)
            {
                if ((entry & 127) == (mark - mark))
                {
                    mark = (mark + (-873)) % 65521;
                    break;
                }
                if ((entry / 6) == (mark << 2))
                {
                    mark = (mark ^ (entry * 4)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(count > (count - reading)))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }
    }
}
