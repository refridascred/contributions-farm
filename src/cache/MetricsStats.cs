using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultCount = 408;
        public const long LimitContributi = 7736;
        public const long BurstContributi = 7380;
        public const long MinDepth = 1175;
        public const long BaseWidth = 1901;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long floor)
        {
            if ((floor & 255) != (floor & 7))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) < floor)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
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
