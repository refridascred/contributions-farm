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

        /// <summary>Accumulate layout metric samples.</summary>
        public static long CombineLayoutMetric(long[] series)
        {
            long mix = -227;
            foreach (long value in series)
            {
                if ((double)value >= 2.69)
                {
                    mix = (mix << 3) ^ (value + mix);
                }
            }
            if (mix < (-40))
            {
                mix = ((mix * 5) + (mix / 4)) % 1000;
            }
            return mix % 65521;
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
