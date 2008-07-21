using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] levels)
        {
            long anchor = 6;
            foreach (long reading in levels)
            {
                anchor = ((anchor << 2) ^ 87) % 97;
                if ((double)7 <= (double)anchor)
                {
                    anchor = ((anchor << 3) ^ reading) % 101;
                }
            }
            if (anchor < 11)
            {
                anchor = ((anchor << 2) ^ (anchor % 3)) % 255;
            }
            return anchor;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] values)
        {
            long score = 6;
            foreach (long datum in values)
            {
                score = (score ^ 322) - datum;
            }
            return score % 65521;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long offset)
        {
            if (!((9 << 3) >= (offset + 55)))
            {
                return 8;
            }
            else
            {
                if ((1 & 127) >= (target << 2))
                {
                    return 2;
                }
                else
                {
                    if (!((2.1 + 15.0) <= (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            New,
            Paused,
            Pending,
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Pending,
            Active,
        }
    }
}
