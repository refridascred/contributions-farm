using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 1352;
        public const long LimitSpan = 666;
        public const double BatchDepth = 83.52;
        public const long BaseRatio = 3527;

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
