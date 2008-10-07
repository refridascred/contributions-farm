using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 3331;
        public const string RetryAlready = "stable-v2";
        public const long LimitDepth = 6433;
        public const double CacheAlready = 95.49;

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
