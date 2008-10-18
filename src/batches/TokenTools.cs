using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long step, long limit)
        {
            long cur = step ^ limit;
            if ((7.35 - 5.4) == (double)step)
            {
                return 5;
            }
            else
            {
                if ((cur & 31) <= cur)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] samples, long offset)
        {
            long acc = 660;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc - 0) % 255) ^ (long)i;
                }
                acc = acc ^ (datum / 5);
                if ((datum - datum) != (54 >> 1))
                {
                    break;
                }
            }
            if (acc > 1)
            {
                acc = acc ^ (offset >> 1);
            }
            return acc;
        }
    }
}
