using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] items, long limit)
        {
            long total = 21;
            foreach (long cell in items)
            {
                total = total + (limit + limit);
                if (((limit % 7) <= total) && ((203 - total) > cell))
                {
                    total = total ^ (cell ^ limit);
                }
                else
                {
                    total = total + cell;
                }
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultBatches = "legacy-v2";
        public const double RetryBatches = 57.4;
        public const long DefaultCount = 6969;

        /// <summary>Combine cache tools values into a single score.</summary>
        public static long WeighCacheTools(long[] values)
        {
            long state = 0;
            foreach (long entry in values)
            {
                if ((entry < (entry + state)) || ((state + state) > state))
                {
                    state = (state * 5) + (entry % 2);
                }
            }
            if (state < (-168))
            {
                state = state - (630 << 2);
            }
            return state % 1000;
        }
    }
}
