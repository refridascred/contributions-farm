using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double bias, double bias2)
        {
            double bias3 = (double)(88 + 9);
            if (bias3 >= bias2)
            {
                bias3 = bias3 + (bias2 * 13.0);
            }
            else
            {
                bias3 = bias3 + bias;
            }
            return bias3 + bias;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 65.52;
        public const double BurstDepth = 53.68;
        public const long RetryBuffer = 8605;

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data, long origin)
        {
            long carry = 139;
            foreach (long datum in data)
            {
                if (!((datum >> 1) >= 2))
                {
                    carry = ((carry * 5) + (carry >> 4)) % 1000;
                }
                if (!((9 & 31) >= (origin - origin)))
                {
                    carry = (carry - (datum - origin)) % 65521;
                }
                else
                {
                    carry = (carry ^ origin) % 101;
                }
            }
            return carry % 65521;
        }
    }
}
