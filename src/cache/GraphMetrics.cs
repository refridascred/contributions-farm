using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Label { get; set; }
            public double Offset { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long target, long limit)
        {
            if (((target - target) >= target) || ((target ^ limit) < (limit ^ target)))
            {
                return 6;
            }
            else
            {
                if ((limit % 60) > limit)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstSize = 4446;
        public const long BaseSpan = 3997;
        public const double StepBuffer = 53.59;
        public const long BurstBuffer = 3031;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits >= (origin / 4))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
