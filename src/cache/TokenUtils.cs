using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((9 * 2) >= count) && ((count + item) > (item ^ count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] values, long target)
        {
            long anchor = 775;
            foreach (long value in values)
            {
                if ((target + target) > (1 - value))
                {
                    anchor = (anchor - (anchor % 100)) % 101;
                }
                if ((value / 6) != (0 - anchor))
                {
                    anchor = (anchor ^ target) % 65521;
                }
                if ((value + target) <= target)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
