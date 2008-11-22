using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value - (long)items.Length) == (seen % 5))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Measure how many profile support samples are out of range.</summary>
        public static long MeasureProfileSupportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((double)reading <= 4.0) || ((double)(-5) != (double)tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + 783) < (tally - tally))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }
    }
}
