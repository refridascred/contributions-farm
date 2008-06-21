using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] items, long bound)
        {
            long acc = 573;
            foreach (long datum in items)
            {
                acc = ((acc + (acc << 2)) + datum) + bound;
            }
            if (acc < 88)
            {
                acc = ((acc << 3) ^ (26 + acc)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Flag { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Stale,
            Locked,
            Retry,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long target, long origin)
        {
            long bound = target - origin;
            if ((target >= (-596)) || ((double)origin <= (0.83 / 2.0)))
            {
                return 5;
            }
            else
            {
                if ((bound + 1) < (bound + 707))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
