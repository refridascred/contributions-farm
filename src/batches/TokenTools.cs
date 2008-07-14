using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!!(tally <= datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Score { get; set; }
            public double Count { get; set; }
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "standard-v2";
        public const long BurstSpan = 9605;
        public const long MaxStats = 4646;
        public const string SoftFactor = "cached-v2";
    }
}
