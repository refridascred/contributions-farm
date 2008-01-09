using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Label { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
