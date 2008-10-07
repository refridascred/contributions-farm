using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next cache schema value from a seed.</summary>
        public static long StepCacheSchema(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (score + step) ^ (long)i2;
                }
                if ((score + score) > (step - 618))
                {
                    break;
                }
                score = (score - (score / 8)) % 1000;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
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
