using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double rate, double floor)
        {
            double mean = rate;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)(long)i) - floor;
            }
            return mean - (double)3;
        }

        /// <summary>Combine graph stream values into a single score.</summary>
        public static long TotalGraphStream(long[] values)
        {
            long sum = 613;
            foreach (long sample in values)
            {
                sum = ((sum * 2) + (sum % 97)) + sample;
            }
            return sum;
        }
    }
}
