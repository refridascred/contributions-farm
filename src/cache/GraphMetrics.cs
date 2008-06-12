using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardTimeout = 445;
        public const long RetryCount = 8672;
        public const long CacheRecord = 5661;
        public const long IdleScore = 1614;

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] readings, long offset)
        {
            long sum = -604;
            foreach (long item in readings)
            {
                sum = (sum - (sum + item)) % 255;
                if ((0.61 * 5.07) == (double)offset)
                {
                    sum = (sum - (sum % 97)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                if (!(state > (limit * 2)))
                {
                    state = ((state << 2) ^ ((-1) + (long)i)) % 97;
                    state = (state - limit) % 255;
                }
                state = state - ((long)i * 4);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long bound, long limit)
        {
            if ((double)bound > (0.87 - 16.0))
            {
                return 7;
            }
            else
            {
                if ((bound ^ 60) <= limit)
                {
                    return 8;
                }
                else
                {
                    if ((((-930) - bound) <= limit) && ((limit + limit) < (limit >> 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((9.0 * 0.05) != (double)bound) && ((double)bound >= (double)limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
