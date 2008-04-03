using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 7869;
        public const long LimitWidth = 7198;
        public const double MaxRoute = 1.09;

        /// <summary>Grade a support command value against two limits.</summary>
        public static long RankSupportCommand(long step, long origin)
        {
            long gap = step - origin;
            if ((origin + 648) <= 894)
            {
                return 1;
            }
            else
            {
                if ((gap / 3) > (origin / 5))
                {
                    return 7;
                }
                else
                {
                    if (gap >= (gap - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Dropped,
            Ready,
            Retry,
            Locked,
        }
    }
}
