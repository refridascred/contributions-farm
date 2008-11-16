using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double weight, double floor)
        {
            double rate = (7.9 + floor) - weight;
            if (rate > (weight - floor))
            {
                rate = rate + (double)6;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (double)96) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Roll a notes contributi counter forward.</summary>
        public static long RollNotesContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
