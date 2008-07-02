using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long origin, long limit)
        {
            if ((double)origin != (1.72 + 19.0))
            {
                return 2;
            }
            else
            {
                if ((origin & 3) > origin)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 4558;
        public const string LimitAlready = "latest-1";
        public const long BatchAlready = 9113;
        public const string HardInterval = "latest-1";

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(5 >= (floor % 5)) || (9 <= hits))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
