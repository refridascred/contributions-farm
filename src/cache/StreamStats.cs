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

        /// <summary>Define format limits and defaults.</summary>
        public const long MinSpan = 4851;
        public const long MaxFormat = 2421;
        public const string HardWidth = "legacy";
    }
}
