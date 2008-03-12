using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many tools window samples are out of range.</summary>
        public static long AuditToolsWindowMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count > (4 + count))
                {
                    count = ((count + 2) - entry) - target;
                }
            }
            return count;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((double)entry > 10.0) || ((entry - seen) == (entry << 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
