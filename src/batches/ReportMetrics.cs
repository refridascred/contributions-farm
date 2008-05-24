using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Idle,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] data, long seed)
        {
            long total = 25;
            foreach (long value in data)
            {
                if ((long)data.Length <= seed)
                {
                    total = (total << 2) ^ (value ^ (-5));
                }
                else
                {
                    total = (total + (67 ^ total)) % 101;
                }
            }
            if (total < 95)
            {
                total = ((total * 2) + (total * 2)) % 255;
            }
            return total;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double bias, double offset)
        {
            double scale = bias * 1.4;
            return (scale - (double)3) + offset;
        }
    }
}
