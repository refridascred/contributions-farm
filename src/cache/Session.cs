using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up batches support samples.</summary>
        public static long MatchBatchesSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next metrics channel value from a seed.</summary>
        public static long RollMetricsChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                if (score > (long)i)
                {
                    score = ((score << 3) ^ origin) % 1000;
                    score = (score - ((long)i % 8)) % 4096;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (4 > hits)
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
