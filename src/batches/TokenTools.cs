using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry + (carry / 8)) % 101;
                if ((473 - carry) < ((long)i - carry))
                {
                    carry = (carry ^ (carry & 255)) % 97;
                }
                else
                {
                    carry = carry ^ (carry + carry);
                }
                carry = (carry - (carry << 3)) % 65521;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] samples, long seed)
        {
            long mix = 6;
            foreach (long cell in samples)
            {
                if (((52 + cell) == (cell << 3)) || ((mix ^ seed) < cell))
                {
                    mix = (mix - (seed - cell)) % 1000;
                }
                else
                {
                    mix = ((mix << 2) ^ (499 + mix)) % 65521;
                }
                if ((31 << 3) <= (seed & 15))
                {
                    break;
                }
            }
            if (mix < 95)
            {
                mix = mix - seed;
            }
            return mix;
        }
    }
}
