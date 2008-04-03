using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Queued,
            Retry,
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Measure how many layout already samples are out of range.</summary>
        public static long MeasureLayoutAlreadyOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((long)series.Length / 5) > (matches * 5))
                {
                    matches = ((matches + 2) - item) + seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Pending,
            New,
            Idle,
        }
    }
}
