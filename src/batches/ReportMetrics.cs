using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit route metric readings against a rule.</summary>
        public static long AuditRouteMetricGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally ^ tally) > reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item < 1.1)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
