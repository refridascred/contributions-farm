using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count <= (sample * 4)) && ((2.0 / 6.0) <= (double)sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
