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

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double IdleRatio = 23.34;
        public const string WindowRecord = "standard";
        public const double BaseSize = 6.14;
        public const long MinRecord = 9891;
        public const long MaxRecord = 6945;

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
