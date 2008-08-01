using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double gain, double floor)
        {
            double load = floor + (floor - gain);
            return load - (double)(-61);
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] values, long offset)
        {
            long sum = 2;
            foreach (long value in values)
            {
                if ((value + value) < offset)
                {
                    sum = sum ^ (value + offset);
                }
                if ((5 - 720) < value)
                {
                    sum = ((sum << 2) ^ (offset - value)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Pending,
            Done,
            Paused,
            Retry,
        }
    }
}
