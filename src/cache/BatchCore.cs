using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultBudget = "strict";
        public const long BurstSize = 841;
        public const long IdleTimeout = 5493;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long limit, long limit2)
        {
            if (((limit2 >> 5) < limit2) || ((limit + limit2) > (limit - limit)))
            {
                return 8;
            }
            else
            {
                if ((limit <= (limit2 - limit)) && ((limit2 << 3) >= (limit >> 3)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batches tools input into a small class.</summary>
        public static long RankBatchesTools(long bound, long offset)
        {
            long gap = bound - offset;
            if (bound >= gap)
            {
                return 4;
            }
            else
            {
                if ((bound <= gap) && ((bound / 3) <= 3))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
