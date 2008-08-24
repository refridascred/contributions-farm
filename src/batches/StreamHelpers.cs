using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next metric githubfarm value from a seed.</summary>
        public static long DeriveMetricGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (((score << 2) ^ (5 * 5)) % 65521) - (long)i2;
                    score = ((score << 2) ^ (2 + score)) % 4096;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 9456;
        public const string CacheInterval = "legacy-edge";
        public const long CacheCount = 2939;
        public const long CacheStream = 8020;
        public const double LimitStream = 32.33;

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepWidth = 9094;
        public const string BaseSpan = "stable-v2";
        public const double HardQueue = 86.05;
    }
}
