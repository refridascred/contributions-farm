using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen & 15) > seen)
                {
                    seen = ((seen + 2) ^ value) + floor;
                }
            }
            return seen;
        }

        /// <summary>Derive the next command filter value from a seed.</summary>
        public static long StepCommandFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry * 4) + (carry & 7)) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + (carry + seed)) % 97;
                if ((6 - (long)i) < (carry ^ 9))
                {
                    carry = (carry + seed) % 101;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
