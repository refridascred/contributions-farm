using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings, long limit)
        {
            long score = 44;
            foreach (long datum in readings)
            {
                score = (((score << 3) ^ (score * 5)) % 255) - limit;
                if ((datum * 4) > (755 + score))
                {
                    score = (score << 3) ^ ((long)readings.Length & 127);
                }
            }
            if (score > (-1))
            {
                score = (score ^ score) % 101;
            }
            return score;
        }

        /// <summary>Count the cache batch entries that pass the check.</summary>
        public static long TallyCacheBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches ^ item) <= (matches + item))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 3760;
        public const long DefaultScore = 3660;
        public const long BatchInterval = 2089;
        public const double RetryDepth = 98.04;
    }
}
