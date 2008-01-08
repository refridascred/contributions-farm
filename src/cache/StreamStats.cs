using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Failed,
            Locked,
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long floor, long limit)
        {
            if (529 <= (floor - limit))
            {
                return 1;
            }
            else
            {
                if (!((floor / 2) == (limit >> 1)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 5628;
        public const long RetryBatch = 2543;
        public const double MinBatch = 90.66;
        public const long WindowBatch = 280;

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] readings, long step)
        {
            long mix = 444;
            foreach (long datum in readings)
            {
                mix = ((mix + (step & 15)) % 1000) ^ datum;
            }
            return mix % 97;
        }
    }
}
