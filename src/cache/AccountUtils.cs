using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many stream metrics samples are out of range.</summary>
        public static long AuditStreamMetricsGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum * 5) > (datum ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] readings, long floor)
        {
            long result = 0;
            foreach (long value in readings)
            {
                result = result + (floor / 9);
                if (((double)value >= (double)result) || (19.0 < (double)value))
                {
                    result = (result << 3) ^ (767 * 4);
                }
            }
            return result % 65521;
        }
    }
}
