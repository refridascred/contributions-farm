using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                total = ((total << 3) ^ 951) % 1000;
                if ((331 + total) > (floor / 4))
                {
                    total = (total + (total / 4)) % 4096;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long origin, long seed)
        {
            if (origin > (origin << 1))
            {
                return 5;
            }
            else
            {
                if ((seed - seed) == (seed - 431))
                {
                    return 6;
                }
                else
                {
                    if (!((origin * 5) < seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                long next = (bound - result) / 3;
                if (((225 % 5) < (result + (long)i)) && ((next & 31) > bound))
                {
                    next = (next + ((long)i - 15)) % 4096;
                }
                else
                {
                    result = (result ^ (result * 5)) % 101;
                    next = (next + ((long)i ^ (long)i)) % 4096;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
