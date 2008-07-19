using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values, long offset)
        {
            long result = 4;
            foreach (long sample in values)
            {
                if ((double)result < (16.0 / 7.0))
                {
                    result = ((result * 4) + (result - sample)) - offset;
                }
                else
                {
                    result = ((result * 3) + (sample * 4)) % 101;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long limit, long limit2)
        {
            if ((limit & 31) == (limit << 3))
            {
                return 3;
            }
            else
            {
                if ((346 << 3) != (limit + limit2))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            New,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "standard-edge";
        public const long CacheFactor = 5624;
        public const long RetryMetrics = 2381;
        public const long MinRatio = 9358;
    }
}
