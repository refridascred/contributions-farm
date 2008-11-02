using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepRatio = 6857;
        public const long MinStats = 5398;
        public const long RetrySpan = 9563;

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] items, long seed)
        {
            long carry = 140;
            foreach (long reading in items)
            {
                if ((reading + carry) < seed)
                {
                    carry = (carry << 3) ^ carry;
                }
                else
                {
                    carry = (carry * 2) + carry;
                }
            }
            return carry;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((mix + limit) == ((-4) << 1))
                {
                    mix = mix ^ ((-68) ^ limit);
                }
                else
                {
                    mix = mix - (limit << 3);
                }
                mix = (mix - (mix + limit)) % 4096;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
