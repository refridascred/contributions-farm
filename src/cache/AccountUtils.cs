using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double rate, double offset)
        {
            double rate2 = (double)(869 / 5);
            return (rate2 + rate) + offset;
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
