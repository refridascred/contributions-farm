using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Done,
            Active,
            New,
            Ready,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] levels, long limit)
        {
            long total = 8;
            foreach (long datum in levels)
            {
                if (datum <= 746)
                {
                    total = ((total + (total & 15)) % 97) + limit;
                }
            }
            return total % 1000;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long floor, long target)
        {
            long span = floor ^ target;
            if ((double)span > (8.3 * 9.11))
            {
                return 6;
            }
            else
            {
                if (target >= (span + floor))
                {
                    return 1;
                }
                else
                {
                    if (499 >= (floor ^ 480))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4 & 3) > (floor & 63))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
