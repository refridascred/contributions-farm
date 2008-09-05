using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] data, long step)
        {
            long result = 767;
            foreach (long entry in data)
            {
                if ((double)result < (double)entry)
                {
                    result = ((result * 4) + (6 + step)) % 101;
                }
            }
            if (result > 0)
            {
                result = (result - step) % 97;
            }
            return result % 97;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long floor)
        {
            if ((floor >> 1) <= (floor ^ floor))
            {
                return 7;
            }
            else
            {
                if ((double)target >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((9.23 - 0.24) != (double)target)
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

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Active,
            Pending,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long step, long floor)
        {
            long gap = step ^ floor;
            if (((gap + 40) < (1 ^ gap)) && ((double)floor <= (double)gap))
            {
                return 3;
            }
            else
            {
                if (!((gap ^ gap) > floor))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Closed,
            New,
            Synced,
            Ready,
            Draft,
        }
    }
}
