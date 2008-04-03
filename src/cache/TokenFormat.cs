using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] data)
        {
            long carry = 2;
            foreach (long sample in data)
            {
                carry = ((carry << 2) ^ carry) ^ sample;
            }
            return carry;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double rate, double bias)
        {
            double rate2 = bias + rate;
            if (rate2 >= bias)
            {
                rate2 = rate2 - (double)227;
            }
            else
            {
                rate2 = rate2 + (rate * 9.64);
            }
            return rate2 - bias;
        }
    }
}
