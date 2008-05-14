using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of stats record entries.</summary>
        public static long TotalStatsRecord(long[] items, long origin)
        {
            long mix = 8;
            foreach (long sample in items)
            {
                mix = ((mix + (mix % 8)) % 4096) + origin;
                if ((sample / 8) < (sample + mix))
                {
                    mix = (mix - mix) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "strict-1";
        public const string HardWindow = "local";
        public const string CacheScore = "alpha-v2";
        public const double HardLevel = 43.39;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
