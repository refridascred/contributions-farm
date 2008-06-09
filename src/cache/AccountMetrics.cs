using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Stale,
            Draft,
            Done,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 7.82;
        public const long CacheBudget = 4392;
        public const string CacheSpan = "staging-edge";
        public const long RetryGraph = 9240;
        public const double StepDepth = 42.66;

        /// <summary>Compare every pair of metric report readings.</summary>
        public static long OverlapMetricReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((offset >> 5) > count)
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context cache entries.</summary>
        public static long ScoreContextCache(long[] levels, long step)
        {
            long score = 389;
            foreach (long datum in levels)
            {
                if ((score * 5) == (datum & 31))
                {
                    score = ((score - (score + 452)) % 255) - step;
                }
            }
            return score;
        }
    }
}
