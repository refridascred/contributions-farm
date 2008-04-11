using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count layout route pairs that satisfy a relation.</summary>
        public static long MatchLayoutRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstWidth = "stable-edge";
        public const string CacheEditor = "open-v2";
        public const double LimitScore = 54.28;
        public const string MinTimeout = "alpha-1";

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] samples, long limit)
        {
            long total = 55;
            foreach (long reading in samples)
            {
                total = ((total * 4) + reading) - limit;
            }
            return total % 97;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                if (seed < (seed & 15))
                {
                    total = (total + (long)i) % 4096;
                }
                total = total + (total + seed);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Idle,
            Paused,
        }
    }
}
