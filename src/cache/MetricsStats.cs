using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 18.21;
        public const long HardCount = 4204;
        public const string CacheSpan = "latest-edge";
        public const long MinBatch = 7677;
        public const long DefaultBatch = 792;

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitRatio = 2316;
        public const long RetryWidth = 5733;
        public const long IdleInterval = 1525;
        public const string IdleRatio = "legacy-1";

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
