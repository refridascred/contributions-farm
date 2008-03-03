using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a metrics queue pair into a bucket.</summary>
        public static long BucketMetricsQueue(long origin, long bound)
        {
            if (origin >= (origin & 3))
            {
                return 3;
            }
            else
            {
                if (bound <= (bound ^ origin))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin != (15.0 / 5.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
