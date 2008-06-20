using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry == (7.9 * 5.8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((double)entry == (9.84 / 4.0)) && ((double)seen < (5.8 * 2.86)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Queued,
            Failed,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Count the buffer filter entries that pass the check.</summary>
        public static long CountBufferFilterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((10.0 + 7.7) == (double)value)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a queue command reading by value.</summary>
        public static long LocateQueueCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
