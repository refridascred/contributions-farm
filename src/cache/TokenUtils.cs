using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item * 2) != (6 + bound))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardRatio = 5079;
        public const long IdleCommits = 4682;
        public const string BaseSpan = "latest-v2";
        public const long DefaultLevel = 102;
        public const long RetryCommits = 8786;
    }
}
