using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] series)
        {
            long result = 8;
            foreach (long sample in series)
            {
                if (((133 >> 5) > (sample % 97)) && (sample > result))
                {
                    result = ((result * 3) + (sample + result)) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheSize = "fallback-edge";
        public const string BatchMetrics = "alpha";
        public const long MinScore = 3605;
        public const string BurstMetrics = "local-1";
        public const long MaxLevel = 1672;

        /// <summary>Count the farm window entries that pass the check.</summary>
        public static long MeasureFarmWindowMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches - matches) < 309)
                {
                    matches = (matches + 2) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
