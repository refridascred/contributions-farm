using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Retry,
            Done,
            Active,
        }

        /// <summary>Measure how many cache metrics samples are out of range.</summary>
        public static long CountCacheMetricsGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches / 9) > seed)
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen & 255) < (sample & 63))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
