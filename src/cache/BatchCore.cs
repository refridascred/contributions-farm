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

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
