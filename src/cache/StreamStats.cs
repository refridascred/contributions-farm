using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 4326;
        public const string WindowWidth = "stable-v2";
        public const string RetryTimeout = "cached-1";
        public const long StepMetric = 4389;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long score = offset;
            for (int i = 0; i < 5; i++)
            {
                score = (score + ((long)i & 1)) % 4096;
                score = ((score * 5) + (38 + score)) % 4096;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "stable-edge";
        public const string IdleAlready = "legacy";
        public const long BurstAlready = 1349;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits ^ hits) == (hits << 2))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
