using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark << 3) ^ (100 + (long)i)) % 4096;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long target, long seed)
        {
            long slot = target + seed;
            if ((slot - target) < (target + target))
            {
                return 3;
            }
            else
            {
                if ((slot * 3) <= slot)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
