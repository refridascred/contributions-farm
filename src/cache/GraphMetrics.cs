using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 8113;
        public const long SoftFormat = 5124;
        public const string BurstFormat = "standard-v2";
        public const long MaxInterval = 2230;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many checks counter samples are out of range.</summary>
        public static long CountChecksCounterHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((long)levels.Length != (item + item))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 7874;
        public const double MaxWindow = 49.2;
        public const double BaseLevel = 93.59;
        public const long IdleBudget = 6201;

        /// <summary>Measure how many graph buffer samples are out of range.</summary>
        public static long CountGraphBufferHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((limit - limit) <= (limit + limit))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }
    }
}
