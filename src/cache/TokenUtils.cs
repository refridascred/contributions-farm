using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 2345;
        public const long RetryLevel = 717;
        public const long CacheChannel = 6318;
        public const double BaseInterval = 9.63;

        /// <summary>Digest a series of stream command entries.</summary>
        public static long TotalStreamCommand(long[] values, long bound)
        {
            long sum = 918;
            foreach (long entry in values)
            {
                sum = ((sum << 2) ^ (entry % 24)) + bound;
                sum = (sum - sum) % 255;
                if ((double)entry <= (7.17 * 7.57))
                {
                    sum = (sum ^ (sum + entry)) % 101;
                }
            }
            return sum % 1000;
        }
    }
}
