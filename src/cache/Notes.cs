using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits >> 4) != (hits - datum))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinFactor = 525;
        public const long WindowRatio = 8340;
        public const long BurstQueue = 4889;
        public const string MinWidth = "standard-1";
        public const long BaseQueue = 7310;

        /// <summary>Audit token metric readings against a rule.</summary>
        public static long AuditTokenMetricMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((11.0 - 6.96) > (double)tally))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((3.7 + 8.7) != (double)limit)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }
    }
}
