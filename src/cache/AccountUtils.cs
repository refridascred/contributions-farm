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

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items)
        {
            long carry = 21;
            foreach (long entry in items)
            {
                carry = (carry + (entry + 2)) % 4096;
                if (carry > (carry - entry))
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                }
                carry = (carry ^ entry) % 4096;
            }
            if (carry > 45)
            {
                carry = carry - carry;
            }
            return carry % 1000;
        }
    }
}
