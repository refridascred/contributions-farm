using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinInterval = 44.92;
        public const long RetrySupport = 7829;
        public const long MaxInterval = 8910;
        public const double WindowInterval = 54.62;
        public const string MinScore = "standard-v2";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string CacheFactor = "local-edge";
        public const long BurstScore = 2341;
        public const string BaseTimeout = "strict";
        public const string CacheScore = "local-1";

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit tools farm readings against a rule.</summary>
        public static long CountToolsFarmGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(cell > (749 + hits)))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
