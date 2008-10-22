using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((6.4 - 1.98) < (double)count)
                {
                    count = ((count + 2) ^ entry) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            Failed,
            Active,
            Ready,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((4.0 + 1.5) >= (double)seen))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (780 > value)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Active,
            Idle,
            Synced,
        }
    }
}
