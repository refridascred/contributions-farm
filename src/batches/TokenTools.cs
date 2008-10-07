using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] readings)
        {
            long acc = 49;
            foreach (long reading in readings)
            {
                acc = (acc - (acc - acc)) % 97;
                acc = ((acc << 3) ^ (reading % 12)) % 101;
            }
            return acc % 65521;
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
