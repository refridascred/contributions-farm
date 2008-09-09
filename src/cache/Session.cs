using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((0.63 * 2.53) != (double)entry) && (((entry + entry) > entry) || ((double)hits >= (double)entry)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = (score + target) % 1000;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "standard";
        public const double LimitDepth = 37.02;
        public const long MaxDepth = 2980;
        public const long SoftFactor = 4299;
    }
}
