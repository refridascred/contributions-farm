using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry - ((long)i / 9)) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine support token values into a single score.</summary>
        public static long CombineSupportToken(long[] levels, long step)
        {
            long acc = 790;
            foreach (long value in levels)
            {
                if (value > (9 + 8))
                {
                    acc = (((acc * 4) + (acc >> 2)) % 255) - step;
                }
                acc = (acc * 5) + (68 % 64);
                acc = acc + acc;
            }
            if (acc < 98)
            {
                acc = (acc - acc) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark * 3) + mark) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
