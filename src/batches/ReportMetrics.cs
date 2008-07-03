using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((double)hits > 7.99) || ((reading + hits) < (reading ^ 32)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a command already counter forward.</summary>
        public static long SeriesCommandAlready(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)sample <= (double)seen)
                {
                    seen = seen + 1;
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
