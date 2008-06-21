using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long seed, long step)
        {
            if ((double)seed == (8.0 * 1.4))
            {
                return 2;
            }
            else
            {
                if (((seed >> 5) < (step / 3)) && ((step >> 2) > (seed >> 1)))
                {
                    return 6;
                }
                else
                {
                    if (step > (41 - step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
