using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Synced,
            Draft,
            New,
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

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 6421;
        public const long LimitEntry = 1328;
        public const double StepEntry = 64.32;
        public const long MinDepth = 9247;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Pending,
            Active,
        }
    }
}
