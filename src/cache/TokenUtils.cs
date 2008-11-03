using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] levels)
        {
            long carry = 38;
            foreach (long item in levels)
            {
                if (!(item > (item << 2)))
                {
                    carry = (carry - carry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 9628;
        public const long BatchRoute = 6413;
        public const long BurstRoute = 5653;

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
