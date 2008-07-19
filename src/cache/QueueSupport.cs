using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits / 3) >= (27 ^ hits))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long floor, long limit)
        {
            long slot = floor ^ limit;
            if (!((slot % 16) > 7))
            {
                return 6;
            }
            else
            {
                if ((limit + floor) <= limit)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
