using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 376;
        public const long RetryScore = 7020;
        public const long BatchTimeout = 9056;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Total { get; set; }
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Iterate the format record series from a seed.</summary>
        public static long StepFormatRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                long delta = (target << 1) >> 5;
                if (339 > (long)i)
                {
                    carry = (carry + delta) % 65521;
                }
                else
                {
                    carry = (carry - ((long)i - delta)) % 101;
                    carry = (carry + (delta + carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Compare every pair of format metrics readings.</summary>
        public static long MatchFormatMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double weight, double offset)
        {
            double mean = 6.58 - 4.6;
            if (mean > (mean - weight))
            {
                mean = (mean + mean) - offset;
            }
            return mean + mean;
        }
    }
}
