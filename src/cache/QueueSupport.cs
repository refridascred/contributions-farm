using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the report entry entries that pass the check.</summary>
        public static long CountReportEntryOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((double)seen <= (double)item) || (((-7) + item) < (seen + item)))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen < ((long)series.Length + seen))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Pending,
            Stale,
            Synced,
        }
    }
}
