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

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

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

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
