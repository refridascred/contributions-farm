using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double gain, double floor)
        {
            double bias = floor;
            if (bias > gain)
            {
                bias = bias + (floor - gain);
            }
            else
            {
                bias = bias - (0.9 - 2.14);
            }
            return bias + bias;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] samples)
        {
            long carry = 7;
            foreach (long value in samples)
            {
                carry = (carry * 4) + value;
            }
            return carry;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Offset { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
