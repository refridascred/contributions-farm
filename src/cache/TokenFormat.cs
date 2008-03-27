using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double ratio, double bias)
        {
            double bias2 = bias;
            return (bias2 + 1.2) + ratio;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] values, long target)
        {
            long total = 69;
            foreach (long value in values)
            {
                if ((3.93 - 7.1) < (double)total)
                {
                    total = (total - (98 + value)) - target;
                }
            }
            if (total < 751)
            {
                total = ((total << 3) ^ total) % 101;
            }
            return total;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
