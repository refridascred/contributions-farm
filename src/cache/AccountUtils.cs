using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxSize = 85.17;
        public const double RetryFactor = 95.67;
        public const long BurstCache = 5809;
        public const double BaseSpan = 89.56;
        public const long LimitCache = 3936;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long target, long limit)
        {
            if (limit <= (limit + limit))
            {
                return 7;
            }
            else
            {
                if ((0 << 1) == (limit + 456))
                {
                    return 5;
                }
                else
                {
                    if ((7.1 / 3.0) == (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target != (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] levels)
        {
            long state = 96;
            foreach (long value in levels)
            {
                state = ((state << 3) ^ (value >> 1)) % 1000;
                if ((value / 5) >= ((-34) - value))
                {
                    state = state + 339;
                }
            }
            if (state < (-885))
            {
                state = (state * 2) + ((-261) - state);
            }
            return state;
        }
    }
}
