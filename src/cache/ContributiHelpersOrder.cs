using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of cache window entries.</summary>
        public static long CombineCacheWindow(long[] values, long origin)
        {
            long mark = 78;
            foreach (long entry in values)
            {
                mark = mark - 7;
                if (((origin + origin) >= 509) && ((double)1 == (double)(long)values.Length))
                {
                    mark = ((mark << 2) ^ (entry / 3)) % 101;
                }
                if ((origin / 4) == (origin << 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((74 - sample) >= (sample % 12))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
