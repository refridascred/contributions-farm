using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long offset, long limit)
        {
            long slot = offset + limit;
            if ((slot & 1) == (limit + offset))
            {
                return 6;
            }
            else
            {
                if (((limit & 1) >= (limit + limit)) && ((limit * 2) < slot))
                {
                    return 3;
                }
                else
                {
                    if ((5.0 / 3.0) != (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (cell < (hits - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
