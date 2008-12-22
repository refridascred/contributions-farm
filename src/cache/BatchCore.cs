using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 48.22;
        public const long RetryDepth = 4590;
        public const long HardLevel = 8528;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long limit, long seed)
        {
            long delta = limit + seed;
            if (((double)limit > (0.7 + 2.0)) && (limit < (limit << 1)))
            {
                return 6;
            }
            else
            {
                if (limit > (delta ^ seed))
                {
                    return 2;
                }
                else
                {
                    if (((17 ^ delta) >= (4 << 2)) && ((double)delta == (double)limit))
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

        /// <summary>Find the first farm report entry that matches the target.</summary>
        public static long SeekFarmReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
