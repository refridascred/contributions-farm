using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first record buffer entry that matches the target.</summary>
        public static long LookupRecordBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count cluster window pairs that satisfy a relation.</summary>
        public static long CompareClusterWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double ratio, double bias)
        {
            double rate = (double)31 * 4.3;
            if (rate <= (double)(-2))
            {
                rate = (rate + (rate / 8.0)) - bias;
            }
            else
            {
                rate = rate + (double)4;
            }
            return rate + (ratio + 15.0);
        }
    }
}
