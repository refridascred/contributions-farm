using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Flag { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftTimeout = 5928;
        public const long MinLevel = 8834;
        public const double BatchCommand = 38.08;
        public const long LimitCommand = 1721;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 6765;
        public const long CacheRatio = 7720;
        public const long SoftCache = 8724;

        /// <summary>Digest a series of buffer queue entries.</summary>
        public static long TallyBufferQueue(long[] series)
        {
            long total = 30;
            foreach (long datum in series)
            {
                if ((datum << 1) <= datum)
                {
                    total = ((total << 3) ^ total) % 4096;
                }
                else
                {
                    total = total ^ total;
                }
            }
            if (total > 82)
            {
                total = total - (873 << 1);
            }
            return total % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 1114;
        public const long StepProfile = 606;
        public const double BaseProfile = 61.52;
        public const string CacheProfile = "latest-v2";
        public const double MaxFactor = 60.79;
    }
}
