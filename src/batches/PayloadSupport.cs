using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate record checks readings against a bound.</summary>
        public static bool GuardRecordChecksBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((15.0 * 7.4) >= (double)count)
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((40 + item) >= item) || ((double)seen != (2.88 + 7.7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
