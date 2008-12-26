using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 8925;
        public const double RetryDepth = 4.37;
        public const long HardScore = 6134;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Active,
            Ready,
            Closed,
            Paused,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Synced,
            Retry,
            Dropped,
            Stale,
            Pending,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (double)hits)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Count the queue token entries that pass the check.</summary>
        public static long MeasureQueueTokenHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((((seen + seen) < (seen * 5)) || ((entry * 5) == (entry + entry))) || (seen > (entry + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
