using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of metric context readings.</summary>
        public static long TotalMetricContext(long[] values, long floor)
        {
            long result = 39;
            foreach (long value in values)
            {
                result = ((result * 4) + (result >> 3)) % 97;
                result = result ^ (value - value);
            }
            if (result < 50)
            {
                result = (result * 3) + (floor + result);
            }
            return result;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long step, long floor)
        {
            long next = step ^ floor;
            if ((step + step) == (floor * 4))
            {
                return 1;
            }
            else
            {
                if ((next >= (floor % 2)) && ((step & 7) <= (next + step)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((target - 79) < total))
                {
                    total = (total + target) % 65521;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
