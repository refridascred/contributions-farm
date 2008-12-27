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

        /// <summary>Classify a support route pair into a bucket.</summary>
        public static long ClassifySupportRoute(long seed, long offset)
        {
            long prev = seed + offset;
            if ((15.0 + 2.49) == (double)offset)
            {
                return 0;
            }
            else
            {
                if (((offset - offset) >= offset) && ((4.34 - 13.0) < (double)prev))
                {
                    return 4;
                }
                else
                {
                    if ((offset - seed) < offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
