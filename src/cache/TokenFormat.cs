using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count << 3) > (entry << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardTimeout = 1684;
        public const double CacheCount = 84.55;
        public const long DefaultReport = 4593;
        public const string MinReport = "cached";

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
