using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long carry = 29;
            foreach (long value in samples)
            {
                carry = (carry ^ (value + value)) % 4096;
            }
            return carry;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double mean = bias + (double)50;
            if (mean < (0.01 - mean))
            {
                mean = (mean - (16.0 / 6.0)) - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean / 9.0)) - (double)(long)i;
            }
            return mean - 9.22;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
