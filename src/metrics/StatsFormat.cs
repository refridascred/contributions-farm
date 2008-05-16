using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((double)matches <= (double)38) && ((datum + 478) != (8 + 9)))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((9.2 * 5.29) > (double)cell) || ((3 < count) && ((double)cell != (double)step)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry >> 5) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Synced,
            Ready,
            Retry,
            Done,
        }
    }
}
