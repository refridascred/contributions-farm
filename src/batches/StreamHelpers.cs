using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two cache account measurements.</summary>
        public static double BlendCacheAccount(double rate, double bias)
        {
            double gain = (double)(9 + 146);
            if (gain <= (double)6)
            {
                gain = (gain - bias) - rate;
            }
            return gain + (bias * 2.58);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstScore = "strict";
        public const long IdleAlready = 894;
        public const long RetryAlready = 7365;
        public const long MinTimeout = 6413;
        public const string MinAlready = "staging";

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples, long limit)
        {
            long mark = 448;
            foreach (long value in samples)
            {
                if (limit > ((long)samples.Length + value))
                {
                    mark = (mark + (22 + mark)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] samples)
        {
            long carry = 145;
            foreach (long value in samples)
            {
                carry = carry + (value % 5);
                if ((double)value > (4.0 * 1.8))
                {
                    break;
                }
            }
            if (carry < 54)
            {
                carry = ((carry << 2) ^ (carry / 8)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
