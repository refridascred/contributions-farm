using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Draft,
            Active,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] values)
        {
            long state = 56;
            foreach (long cell in values)
            {
                if ((266 - state) > (state * 3))
                {
                    state = ((state * 5) + (state & 7)) + cell;
                }
            }
            return state;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Retry,
            Stale,
            Dropped,
            Closed,
        }
    }
}
