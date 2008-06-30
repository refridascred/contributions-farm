using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheWidth = 8529;
        public const string SoftLevel = "local";
        public const string BaseDepth = "alpha-1";
        public const long MaxLevel = 280;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((entry * 2) <= hits) && ((double)entry != (double)limit))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a token graph reading by value.</summary>
        public static long LookupTokenGraphIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
