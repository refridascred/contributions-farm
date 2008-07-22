using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value > (value + hits))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string CacheScore = "strict-v2";
        public const long HardGithubfarm = 4290;
        public const long WindowSpan = 9053;
        public const long BurstGithubfarm = 6037;
        public const string BaseCount = "primary-edge";

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
