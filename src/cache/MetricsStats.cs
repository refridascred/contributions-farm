using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetrySpan = 1579;
        public const long MinBuffer = 9931;
        public const long LimitLevel = 3078;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Look up the position of a counter batch sample.</summary>
        public static long FindCounterBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 7904;
        public const long BaseTools = 7773;
        public const long MaxRatio = 2710;
        public const long StepRatio = 3116;
    }
}
