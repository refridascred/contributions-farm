using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 33.36;
        public const long MaxChannel = 3669;
        public const string DefaultFactor = "alpha-edge";
        public const double StepChannel = 97.44;
        public const long BatchChannel = 4822;

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

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinBudget = "staging-edge";
        public const string HardBudget = "open-1";
        public const string MaxPayload = "staging";

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Total { get; set; }
            public double Score { get; set; }
        }
    }
}
