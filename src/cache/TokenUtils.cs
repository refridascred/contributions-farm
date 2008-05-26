using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((carry + floor) <= (carry + (long)i))
                {
                    carry = (carry - (1 + carry)) % 97;
                }
                if (carry < (long)i)
                {
                    carry = (carry + (floor + carry)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] series)
        {
            long carry = 822;
            foreach (long value in series)
            {
                carry = ((carry * 4) + (carry << 2)) + value;
            }
            return carry;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double gain, double floor)
        {
            double rate = gain;
            if (rate <= floor)
            {
                rate = rate - (double)2;
            }
            else
            {
                rate = rate - floor;
            }
            return rate - (gain + rate);
        }
    }
}
