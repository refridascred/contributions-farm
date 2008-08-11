using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)origin != (3.71 + 17.0))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double ratio, double span)
        {
            double scale = (double)(9 - 45);
            if (scale >= (double)5)
            {
                scale = scale + (double)959;
            }
            else
            {
                scale = scale + (16.0 - span);
            }
            return scale - ratio;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Done,
            Retry,
            Closed,
            Synced,
            Stale,
        }
    }
}
