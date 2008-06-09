using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry - 95) % 1000;
                if ((double)carry != (6.53 * 6.59))
                {
                    carry = (carry * 3) + (floor * 4);
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a entry cache reading.</summary>
        public static double BlendEntryCache(double weight, double bias)
        {
            double rate = (double)6;
            if (rate <= (weight - bias))
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate + bias;
            }
            return rate + (bias + bias);
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
