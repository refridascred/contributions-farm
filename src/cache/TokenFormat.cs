using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Blend two metrics account measurements.</summary>
        public static double BlendMetricsAccount(double weight, double floor)
        {
            double load = weight;
            for (int i = 0; i < 9; i++)
            {
                load = (load - (double)(long)i) - floor;
            }
            return load - weight;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] items)
        {
            long carry = 60;
            foreach (long cell in items)
            {
                carry = (carry * 3) + (cell >> 5);
                if (carry > (carry + (long)items.Length))
                {
                    carry = (carry << 2) ^ (cell << 3);
                }
                else
                {
                    carry = ((carry << 2) ^ (cell << 1)) % 65521;
                }
            }
            return carry % 97;
        }
    }
}
