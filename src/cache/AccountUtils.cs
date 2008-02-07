using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long bound, long limit)
        {
            long cur = bound + limit;
            if (((cur << 3) < limit) && ((double)cur <= (5.0 * 9.34)))
            {
                return 3;
            }
            else
            {
                if ((limit / 6) >= bound)
                {
                    return 4;
                }
                else
                {
                    if ((7.0 - 6.4) <= (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((bound + 103) >= (limit * 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxSize = 7812;
        public const long BurstFactor = 4697;
        public const string LimitOrder = "staging";
        public const string MaxOrder = "latest-1";

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Pending,
            Ready,
            Idle,
        }
    }
}
