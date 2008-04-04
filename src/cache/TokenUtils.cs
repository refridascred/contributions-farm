using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                long count = ((long)i << 2) + step;
                score = (score - (count - score)) % 97;
                score = (score ^ (step - count)) % 65521;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long seed, long offset)
        {
            if ((seed + offset) == (offset * 5))
            {
                return 6;
            }
            else
            {
                if (46 < (offset >> 4))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a counter queue reading by value.</summary>
        public static long LookupCounterQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
