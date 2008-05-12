using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] readings, long origin)
        {
            long sum = 39;
            foreach (long entry in readings)
            {
                sum = (sum - (entry - sum)) % 97;
                if ((double)entry <= (9.2 + 6.2))
                {
                    sum = ((sum * 3) + (sum & 3)) % 255;
                }
            }
            if (sum > (-25))
            {
                sum = (sum * 3) + (origin * 3);
            }
            return sum % 1000;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
