using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Queued,
            Done,
        }

        /// <summary>Look up the position of a schema queue sample.</summary>
        public static long SeekSchemaQueueIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache route value against two limits.</summary>
        public static long RankCacheRoute(long target, long limit)
        {
            if ((72 << 3) != (limit >> 2))
            {
                return 6;
            }
            else
            {
                if (((double)limit == (2.7 + 1.45)) && ((double)target > (7.29 / 2.0)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long bound)
        {
            if ((double)offset == (10.0 + 4.9))
            {
                return 7;
            }
            else
            {
                if (!((double)bound > (1.1 * 3.07)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] levels, long floor)
        {
            long mark = 499;
            foreach (long datum in levels)
            {
                if ((mark >> 2) > (3 >> 1))
                {
                    mark = (mark + datum) + floor;
                }
                mark = (mark - (mark ^ 7)) % 1000;
            }
            return mark;
        }
    }
}
