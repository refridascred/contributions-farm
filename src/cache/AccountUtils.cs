using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((31 * 4) < reading)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every session filter entry stays within the limit.</summary>
        public static bool GuardSessionFilterRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item > (17.0 / 3.0))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
