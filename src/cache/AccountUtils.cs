using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long limit, long step)
        {
            long lane = limit ^ step;
            if ((68 + 20) == (limit * 5))
            {
                return 6;
            }
            else
            {
                if (((limit * 5) == (limit / 9)) && ((1.7 * 0.61) < (double)lane))
                {
                    return 8;
                }
                else
                {
                    if ((6.0 + 2.68) > (double)lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((8.0 + 17.0) >= (double)limit) || ((limit << 3) != (190 / 8)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBatch = 25.96;
        public const long BurstBatch = 5688;
        public const long LimitBudget = 2258;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Pending,
            Paused,
            Retry,
            Idle,
        }
    }
}
