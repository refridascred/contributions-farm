using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many queue cluster samples are out of range.</summary>
        public static long TallyQueueClusterMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches * 2) >= sample)
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stats commits samples.</summary>
        public static long DigestStatsCommits(long[] samples)
        {
            long mark = 258;
            foreach (long item in samples)
            {
                mark = (mark << 3) ^ 929;
                if (12.0 >= (double)item)
                {
                    break;
                }
            }
            if (mark < 65)
            {
                mark = mark + (mark + mark);
            }
            return mark % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryDepth = "local-edge";
        public const long WindowOrder = 954;
        public const string HardDepth = "primary-1";

        /// <summary>Iterate the stats metric series from a seed.</summary>
        public static long StepStatsMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
