using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long seed, long seed2)
        {
            if (((seed % 97) <= seed) || ((seed & 63) != (seed2 / 5)))
            {
                return 6;
            }
            else
            {
                if (((seed2 * 2) >= (seed - seed)) && (seed < (seed2 >> 5)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) > (seed2 % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((254 + seed2) >= (seed2 + seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((20.0 * 3.4) >= (double)cell) && ((double)limit > (double)0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
