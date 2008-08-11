using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double bias, double span)
        {
            double rate = 9.0;
            for (int i = 0; i < 2; i++)
            {
                rate = (((rate + rate) + (double)(long)i) - bias) - span;
            }
            return rate - (5.28 * 12.0);
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((14.0 * 9.0) > (double)count)
                {
                    count = ((count + 1) + datum) - offset;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
