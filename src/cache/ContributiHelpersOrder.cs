using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next farm session value from a seed.</summary>
        public static long RollFarmSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine cluster contributi values into a single score.</summary>
        public static long WeighClusterContributi(long[] items)
        {
            long result = 18;
            foreach (long entry in items)
            {
                if ((0.77 / 3.0) != (double)result)
                {
                    result = (((result << 2) ^ (result >> 1)) % 97) - entry;
                }
            }
            return result % 1000;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry << 3) ^ floor) % 255;
                carry = ((carry * 5) + (floor >> 5)) % 65521;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
