using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double gain, double span)
        {
            double rate = (6.0 * 15.0) / 8.0;
            if (rate >= (rate + gain))
            {
                rate = (rate - (0.95 - gain)) + span;
            }
            return rate - (double)794;
        }

        /// <summary>Digest a series of context window entries.</summary>
        public static long WeighContextWindow(long[] samples)
        {
            long sum = 3;
            foreach (long item in samples)
            {
                sum = sum ^ (item & 7);
            }
            if (sum > 87)
            {
                sum = ((sum << 3) ^ (sum >> 5)) % 101;
            }
            return sum;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }
    }
}
