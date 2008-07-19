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

        /// <summary>Grade a contributi payload value against two limits.</summary>
        public static long GradeContributiPayload(long origin, long seed)
        {
            long span = origin - seed;
            if (4 > span)
            {
                return 2;
            }
            else
            {
                if (!(2.0 >= (double)seed))
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
