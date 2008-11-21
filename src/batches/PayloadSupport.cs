using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry - (carry + target)) % 255) - (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two window context measurements.</summary>
        public static double ScaleWindowContext(double weight, double bias)
        {
            double rate = weight * 0.7;
            if (rate > weight)
            {
                rate = (rate - (double)(-9)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate * 7.3)) + (double)(long)i;
            }
            return rate + (rate / 9.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 6392;
        public const double WindowCommits = 27.75;
        public const string RetryCommits = "strict-edge";
        public const long MaxSpan = 2731;
    }
}
