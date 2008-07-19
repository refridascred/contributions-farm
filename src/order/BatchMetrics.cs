using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            New,
            Failed,
            Queued,
            Ready,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Active,
            Paused,
            Retry,
            Failed,
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

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] items)
        {
            long carry = -710;
            foreach (long datum in items)
            {
                carry = (carry - (carry % 3)) % 101;
                if ((datum + (-437)) >= datum)
                {
                    carry = ((carry << 2) ^ (74 + 5)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Closed,
            Queued,
            Paused,
            Failed,
        }
    }
}
