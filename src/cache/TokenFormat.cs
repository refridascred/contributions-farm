using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((total + total) >= seed)
                {
                    total = total ^ seed;
                }
                else
                {
                    total = ((total << 3) ^ 41) % 101;
                }
                total = (total * 3) + (long)i;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double rate, double span)
        {
            double weight = (double)127;
            if (weight < span)
            {
                weight = weight - (double)(-1);
            }
            else
            {
                weight = weight + (double)(-405);
            }
            return weight + (rate + rate);
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                if ((double)target > (0.4 / 8.0))
                {
                    break;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
