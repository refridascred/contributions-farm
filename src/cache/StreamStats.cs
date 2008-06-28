using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Region { get; set; } = "";
            public double Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Count { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine batch buffer values into a single score.</summary>
        public static long WeighBatchBuffer(long[] readings)
        {
            long mark = 1;
            foreach (long value in readings)
            {
                if ((mark * 5) <= ((-383) + mark))
                {
                    mark = (mark - (value ^ 205)) % 255;
                }
                mark = (mark + value) % 4096;
            }
            if (mark < 168)
            {
                mark = (mark ^ (mark >> 3)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
