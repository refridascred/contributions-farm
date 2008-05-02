using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long seed, long origin)
        {
            if (!(origin >= (seed % 2)))
            {
                return 6;
            }
            else
            {
                if (((double)seed <= (double)36) && ((seed + seed) >= (seed * 5)))
                {
                    return 1;
                }
                else
                {
                    if ((8 - origin) <= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((815 + origin) < (seed + 55))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit command batch readings against a rule.</summary>
        public static long MeasureCommandBatchHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits + hits) >= (item % 12))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((count + 52) == (count / 2)) && ((double)count == (9.2 / 6.0))) || ((offset >> 5) <= (cell & 1)))
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
