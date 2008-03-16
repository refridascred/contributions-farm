using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the profile metric entries that pass the check.</summary>
        public static long TallyProfileMetricMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 2) == (27 + reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cluster queue sample.</summary>
        public static long LookupClusterQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = (state + 56) % 97;
                state = (state << 2) ^ (state - (long)i);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
            public bool Region { get; set; }
        }
    }
}
