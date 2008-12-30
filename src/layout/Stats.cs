using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] data, long seed)
        {
            long anchor = 787;
            foreach (long entry in data)
            {
                anchor = ((anchor << 3) ^ (seed - seed)) ^ entry;
            }
            return anchor % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinDepth = 85.79;
        public const long RetryFormat = 7159;
        public const string CacheFormat = "primary-edge";
        public const string MaxScore = "fallback";
        public const long IdleDepth = 9103;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long floor, long bound)
        {
            long edge = floor ^ bound;
            if ((floor - floor) >= bound)
            {
                return 0;
            }
            else
            {
                if ((bound - floor) == (floor - edge))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
