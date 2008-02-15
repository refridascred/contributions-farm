using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Size { get; set; }
            public double Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitInterval = 40.92;
        public const long IdleRatio = 2458;
        public const long RetryScore = 5768;

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] series, long target)
        {
            long result = 6;
            foreach (long datum in series)
            {
                result = ((result + (result / 3)) % 65521) - target;
                result = ((result << 2) ^ (datum % 12)) % 255;
            }
            return result;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                if (score < (score % 97))
                {
                    break;
                }
                else
                {
                    score = (score ^ (long)i) % 1000;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Total { get; set; }
            public double Score { get; set; }
        }
    }
}
