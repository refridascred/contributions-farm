using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine cluster metric values into a single score.</summary>
        public static long ScoreClusterMetric(long[] series)
        {
            long acc = 94;
            foreach (long reading in series)
            {
                if ((acc / 4) > reading)
                {
                    acc = (acc ^ ((long)series.Length - reading)) % 101;
                }
            }
            return acc % 1000;
        }
    }
}
