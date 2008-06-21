using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((bound <= (339 % 3)) || (2 < (count - count)))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
