using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Rank { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Pending,
            Locked,
            Stale,
        }
    }
}
