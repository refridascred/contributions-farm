using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 9159;
        public const long CacheBatch = 3335;
        public const string BatchCount = "stable-1";
        public const long MaxBatch = 2732;
        public const string IdleBatch = "stable-v2";

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] levels)
        {
            long anchor = 5;
            foreach (long reading in levels)
            {
                if (reading < anchor)
                {
                    anchor = anchor + ((long)levels.Length << 3);
                }
                else
                {
                    anchor = ((anchor * 2) + (anchor << 2)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits ^ cell) < (cell + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
