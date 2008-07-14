using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double weight, double bias)
        {
            double scale = weight / 7.0;
            if (scale <= (bias + weight))
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (weight - weight)) + (double)(long)i;
            }
            return scale + (double)7;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                if (((seed % 97) > carry) || ((seed + seed) >= (carry + seed)))
                {
                    carry = ((carry * 5) + (seed >> 1)) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                carry = carry - (target + target);
                carry = carry + ((long)i + carry);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
