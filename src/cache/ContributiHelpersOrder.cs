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

        /// <summary>Count the tools context entries that pass the check.</summary>
        public static long MeasureToolsContextOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value & 1) < seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
