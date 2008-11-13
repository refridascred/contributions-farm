using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark ^ mark) % 97;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitDepth = 6133;
        public const long SoftWidth = 488;
        public const long CacheToken = 1003;

        /// <summary>Grade a context queue value against two limits.</summary>
        public static long BucketContextQueue(long origin, long limit)
        {
            long bound = origin + limit;
            if (((double)bound <= (2.4 - 1.33)) && (origin < (origin + limit)))
            {
                return 7;
            }
            else
            {
                if (bound < (limit + (-9)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
