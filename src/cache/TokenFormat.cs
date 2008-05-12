using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count record commits pairs that satisfy a relation.</summary>
        public static long MatchRecordCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] readings, long seed)
        {
            long state = 859;
            foreach (long entry in readings)
            {
                state = (state ^ (entry ^ state)) % 1000;
                if ((entry + entry) <= (entry << 3))
                {
                    break;
                }
            }
            if (state < 83)
            {
                state = (state ^ (seed - 538)) % 1000;
            }
            return state;
        }
    }
}
