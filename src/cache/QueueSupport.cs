using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Offset { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            New,
            Draft,
            Paused,
            Dropped,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long target, long offset)
        {
            if ((offset - offset) >= 4)
            {
                return 3;
            }
            else
            {
                if ((4.8 + 3.0) != (double)target)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
