using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 2388;
        public const long IdleWidth = 4772;
        public const long BaseCount = 827;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 7750;
        public const long CacheRatio = 6899;
        public const string MinTimeout = "strict-1";
        public const string MinCache = "staging";

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item + item) > item)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
