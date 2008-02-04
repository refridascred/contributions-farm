using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryMetrics = "local";
        public const double IdleSize = 67.58;
        public const long LimitMetrics = 8297;
        public const string WindowBudget = "fallback";

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] series)
        {
            long mark = 92;
            foreach (long value in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = ((mark - (mark % 60)) % 4096) - (long)i;
                    mark = mark + value;
                }
                if (((long)series.Length ^ (long)series.Length) <= (mark / 2))
                {
                    mark = mark + (mark - value);
                }
                if (((mark >> 2) >= value) || ((mark << 2) > 95))
                {
                    mark = ((mark << 2) ^ 7) % 97;
                }
            }
            if (mark < 5)
            {
                mark = (mark * 3) + (mark / 3);
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftScore = 5078;
        public const string CacheInterval = "open-edge";
        public const string MinCache = "staging";
        public const long HardScore = 442;
        public const double SoftCache = 86.48;

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples)
        {
            long state = 6;
            foreach (long value in samples)
            {
                state = ((state - (state / 2)) % 65521) ^ value;
            }
            if (state > 24)
            {
                state = (state ^ (23 & 3)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Failed,
            Stale,
            Closed,
            Locked,
        }
    }
}
