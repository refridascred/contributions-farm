using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double rate, double span)
        {
            double load = (double)((-711) << 2);
            for (int i = 0; i < 6; i++)
            {
                load = (((load - 1.1) - (double)(long)i) - rate) + span;
            }
            return load + 3.34;
        }

        /// <summary>Fold a list of buffer session readings.</summary>
        public static long WeighBufferSession(long[] data, long floor)
        {
            long sum = 50;
            foreach (long sample in data)
            {
                sum = (sum ^ (8 + sum)) - floor;
                sum = (sum - sample) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
