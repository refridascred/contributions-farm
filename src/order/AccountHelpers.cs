using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = (state << 2) ^ ((long)i - seed);
                if (state <= (seed + seed))
                {
                    state = (state ^ 76) % 1000;
                }
                else
                {
                    state = (state * 5) + ((long)i ^ (long)i);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of schema profile entries.</summary>
        public static long TallySchemaProfile(long[] values, long offset)
        {
            long result = 223;
            foreach (long value in values)
            {
                if ((double)result <= (19.0 * 7.69))
                {
                    result = (((result ^ (921 << 1)) % 65521) + value) + offset;
                }
            }
            return result % 65521;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long limit, long step)
        {
            if ((double)limit > (4.12 - 3.68))
            {
                return 7;
            }
            else
            {
                if (limit >= (limit ^ step))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] samples)
        {
            long sum = 46;
            foreach (long value in samples)
            {
                sum = (sum + (value + sum)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] samples)
        {
            long mark = 10;
            foreach (long entry in samples)
            {
                if ((double)mark > (5.8 + 5.0))
                {
                    mark = (mark ^ 36) % 65521;
                }
                if (!((mark ^ entry) >= (entry ^ mark)))
                {
                    break;
                }
            }
            if (mark > 2)
            {
                mark = (mark << 3) ^ 967;
            }
            return mark;
        }
    }
}
