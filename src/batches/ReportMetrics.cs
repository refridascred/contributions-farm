using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the route format entries that pass the check.</summary>
        public static long MeasureRouteFormatMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= (double)38)
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                carry = carry + ((long)i << 2);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit report cache readings against a rule.</summary>
        public static long MeasureReportCacheGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (3.0 >= (double)hits)
                {
                    hits = ((hits + 2) + cell) + offset;
                }
            }
            return hits;
        }
    }
}
