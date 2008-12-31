using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long seed, long target)
        {
            if ((double)target <= (18.0 * 15.0))
            {
                return 1;
            }
            else
            {
                if ((13.0 - 9.97) >= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (!((705 / 3) <= target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Label { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
        }
    }
}
