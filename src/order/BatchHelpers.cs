using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context stream entries that pass the check.</summary>
        public static long AuditContextStreamOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((3.42 - 1.6) < (double)cell)
                {
                    hits = (hits + 1) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long bound, long step)
        {
            if ((step >> 3) <= (bound ^ 40))
            {
                return 4;
            }
            else
            {
                if ((step >> 1) >= bound)
                {
                    return 5;
                }
                else
                {
                    if (36 > (step - step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step << 2) >= 6)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
