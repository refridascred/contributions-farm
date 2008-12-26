using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] readings, long floor)
        {
            long sum = 78;
            foreach (long value in readings)
            {
                if (((floor & 63) != (4 >> 5)) || ((floor + (long)readings.Length) >= (floor * 3)))
                {
                    sum = (sum * 5) + (floor + value);
                }
            }
            return sum;
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
