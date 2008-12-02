using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long offset, long limit)
        {
            if ((offset + limit) == (limit - 914))
            {
                return 4;
            }
            else
            {
                if (offset <= (1 - 631))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Queued,
            Paused,
            New,
            Dropped,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long floor)
        {
            long sum = 24;
            foreach (long reading in levels)
            {
                if (!(reading > (sum + sum)))
                {
                    sum = ((sum + sum) % 97) - floor;
                }
            }
            return sum;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Paused,
            Done,
            Queued,
            Closed,
        }
    }
}
