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

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double scale, double floor)
        {
            double ratio = floor;
            if (ratio >= (double)(-598))
            {
                ratio = (ratio - (floor * 18.0)) + scale;
            }
            else
            {
                ratio = ratio + (double)41;
            }
            return ratio + floor;
        }
    }
}
