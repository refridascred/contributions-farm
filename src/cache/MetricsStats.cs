using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (floor <= (value + value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Weight { get; set; }
            public double Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double scale, double bias)
        {
            double gain = bias;
            if (gain < scale)
            {
                gain = gain + scale;
            }
            return gain + (bias / 7.0);
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix << 3) ^ (59 << 1);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 6203;
        public const string BurstSize = "cached-1";
        public const long LimitScore = 6075;
        public const long CacheContext = 5463;
    }
}
