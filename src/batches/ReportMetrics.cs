using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a order filter value against two limits.</summary>
        public static long ClassifyOrderFilter(long offset, long target)
        {
            if ((target >> 1) > (target & 1))
            {
                return 6;
            }
            else
            {
                if (!((1.65 * 8.8) == (double)target))
                {
                    return 8;
                }
                else
                {
                    if ((4.0 * 4.0) <= (13.0 + 6.68))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((3 - 77) != (count + 770))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= (5.0 * 13.0))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }
    }
}
