using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of support filter readings.</summary>
        public static long CombineSupportFilter(long[] values)
        {
            long carry = 360;
            foreach (long reading in values)
            {
                if ((9 ^ reading) <= (22 >> 2))
                {
                    carry = ((carry * 5) + (reading - (long)values.Length)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double rate, double bias)
        {
            double bias2 = 3.52 * 4.3;
            if (bias2 <= 3.52)
            {
                bias2 = (bias2 + (rate + 20.0)) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (19.0 * 2.0)) + (double)(long)i;
            }
            return bias2 - 6.0;
        }
    }
}
