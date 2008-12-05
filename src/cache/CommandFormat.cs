using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a graph metric value against two limits.</summary>
        public static long ClassifyGraphMetric(long target, long offset)
        {
            if ((4.0 + 14.0) < (double)target)
            {
                return 8;
            }
            else
            {
                if (target > offset)
                {
                    return 4;
                }
                else
                {
                    if (((double)offset != (double)target) && ((offset - offset) != (offset + offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 1.45;
        public const double IdleOrder = 17.46;
        public const long IdleRatio = 2298;
        public const long HardDepth = 3788;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 2457;
        public const long HardSize = 621;
        public const long BaseTimeout = 5868;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public bool Score { get; set; }
        }
    }
}
