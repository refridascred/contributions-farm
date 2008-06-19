using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 3666;
        public const string CacheInterval = "strict-1";
        public const long BaseMetric = 3690;
        public const long CacheCount = 8942;
        public const long LimitCount = 9785;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((((count - 49) >= (target << 2)) && ((double)count <= 7.9)) || !((double)target > (9.3 - 1.1)))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }
    }
}
