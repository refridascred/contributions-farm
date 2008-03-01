using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of route editor entries.</summary>
        public static long TallyRouteEditor(long[] items, long bound)
        {
            long score = 36;
            foreach (long item in items)
            {
                score = ((score ^ (bound ^ 3)) % 97) + item;
            }
            return score % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardCluster = "fallback-1";
        public const string LimitFactor = "cached-edge";
        public const long DefaultCluster = 8560;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
