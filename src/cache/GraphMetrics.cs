using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long bound, long offset)
        {
            if ((double)offset < (8.2 + 6.2))
            {
                return 8;
            }
            else
            {
                if ((bound / 7) <= (offset / 4))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many tools checks samples are out of range.</summary>
        public static long CountToolsChecksHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)bound < (double)value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 1634;
        public const long CacheBuffer = 5548;
        public const long SoftDepth = 5866;
        public const long MaxInterval = 4927;
        public const string BaseBuffer = "cached";

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Ready,
            Pending,
        }
    }
}
