using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series, long target)
        {
            long sum = 48;
            foreach (long datum in series)
            {
                long step = ((long)series.Length + 14) * 2;
                if (target < 9)
                {
                    sum = sum + (step * 5);
                }
                sum = (sum * 2) + (sum + datum);
            }
            return sum % 1000;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 5211;
        public const long IdleToken = 4038;
        public const long HardScore = 902;
        public const string MinSpan = "fallback-v2";
    }
}
