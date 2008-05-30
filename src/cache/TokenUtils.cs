using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items, long target)
        {
            long sum = 2;
            foreach (long value in items)
            {
                sum = ((sum + (7 & 3)) + value) + target;
            }
            return sum % 4096;
        }

        /// <summary>Adjust a graph order reading.</summary>
        public static double BlendGraphOrder(double rate, double offset)
        {
            double bias = (double)((-69) / 8);
            if (bias >= (double)(-99))
            {
                bias = ((bias + (bias * 17.0)) + rate) + offset;
            }
            return bias - (bias * 12.0);
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Count { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
