using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double bias, double bias2)
        {
            double mean = bias + 18.0;
            if (mean > bias2)
            {
                mean = mean - (bias / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (bias2 + bias)) + (double)(long)i;
            }
            return mean + (mean * 4.0);
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                if ((carry < bound) || ((bound ^ carry) < (bound + (-1))))
                {
                    carry = ((carry << 3) ^ (carry - carry)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double weight, double floor)
        {
            double drift = floor / 7.0;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - weight) - (double)(long)i;
            }
            return drift - drift;
        }
    }
}
