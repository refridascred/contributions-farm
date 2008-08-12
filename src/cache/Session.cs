using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((2.0 - 5.97) < (double)cell)
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Synced,
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Count the session cluster entries that pass the check.</summary>
        public static long MeasureSessionClusterHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((origin << 3) >= (count * 5))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
