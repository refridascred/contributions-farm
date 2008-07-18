using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a contributi token sample.</summary>
        public static long SeekContributiTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = mix ^ bound;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Flag { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 7667;
        public const long RetrySize = 4198;
        public const long BaseBudget = 2521;

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftRatio = 6237;
        public const double LimitWidth = 28.24;
        public const long HardLevel = 2350;
        public const long MaxCommits = 8256;
    }
}
