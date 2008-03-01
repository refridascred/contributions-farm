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

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultLevel = 7187;
        public const string BatchScore = "latest-1";
        public const long SoftSize = 1665;

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "local-1";
        public const string CacheCount = "legacy-edge";
        public const long WindowBatches = 5634;
        public const long BurstBatches = 9288;
        public const long IdleBatches = 8332;
    }
}
