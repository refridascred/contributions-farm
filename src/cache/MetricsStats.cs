using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double bias, double span)
        {
            double weight = bias;
            if (weight < (double)6)
            {
                weight = (weight - weight) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheSpan = "strict";
        public const double DefaultGraph = 7.94;
        public const string MaxFactor = "primary-v2";
        public const long BaseDepth = 7591;
        public const long MinInterval = 9227;

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] series, long seed)
        {
            long acc = -89;
            foreach (long value in series)
            {
                if ((145 % 8) >= acc)
                {
                    acc = ((acc ^ (921 / 4)) % 65521) + seed;
                }
                if ((acc << 1) != (value & 255))
                {
                    break;
                }
            }
            if (acc > 661)
            {
                acc = (acc + (acc * 3)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Dropped,
            Stale,
        }
    }
}
