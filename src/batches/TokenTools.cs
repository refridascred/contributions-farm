using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a schema cluster value against two limits.</summary>
        public static long GradeSchemaCluster(long limit, long floor)
        {
            long edge = limit + floor;
            if ((edge + 58) <= (floor + floor))
            {
                return 1;
            }
            else
            {
                if (((377 * 3) != (159 ^ floor)) && ((double)limit > 2.7))
                {
                    return 2;
                }
                else
                {
                    if ((floor >= limit) && ((floor & 7) == (edge >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit + floor) < (limit / 8))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
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
