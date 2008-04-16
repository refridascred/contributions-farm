using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((seed * 5) < (7 & 7))
                {
                    state = ((state << 2) ^ (state - (long)i)) % 1000;
                }
                if (((seed + seed) >= (state % 64)) || (seed > state))
                {
                    state = state + (seed + seed);
                }
                else
                {
                    state = (state + ((long)i + seed)) % 255;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
