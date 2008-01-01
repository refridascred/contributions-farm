using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the report editor entries that pass the check.</summary>
        public static long MeasureReportEditorGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches + offset) < (offset << 2))
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((bound + bound) <= sample) && (((sample >> 4) > (418 & 127)) && (hits <= bound)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (5.3 > (double)seen)
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
