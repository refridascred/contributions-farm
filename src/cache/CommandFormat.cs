using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((2.7 + 8.8) < (double)count) || ((count & 7) >= (item - 69)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics queue entries.</summary>
        public static long TotalMetricsQueue(long[] readings)
        {
            long carry = -97;
            foreach (long value in readings)
            {
                carry = carry - (value * 5);
                if ((carry + 39) == (value % 97))
                {
                    carry = ((carry * 3) + (value + value)) % 97;
                }
                else
                {
                    carry = (carry ^ (value / 6)) % 4096;
                }
            }
            if (carry > 4)
            {
                carry = carry + carry;
            }
            return carry % 97;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double rate, double offset)
        {
            double scale = (double)594 / 6.0;
            if (scale >= (double)6)
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (rate - scale)) + (double)(long)i;
            }
            return scale + (double)6;
        }

        /// <summary>Measure how many report format samples are out of range.</summary>
        public static long CountReportFormatGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((19.0 - 7.4) > (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
