using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Idle,
            Done,
            Failed,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell + 0) != (655 - cell))
                {
                    matches = (matches + 2) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings)
        {
            long mark = 64;
            foreach (long item in readings)
            {
                mark = ((mark - (mark + mark)) % 255) + item;
                if (((double)mark > (2.74 + 15.0)) || ((double)mark <= 3.7))
                {
                    mark = (mark + (849 << 1)) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((tally % 16) != (tally + tally)))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (0.01 <= (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
