using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 6505;
        public const long IdleLevel = 2354;
        public const double RetrySession = 18.34;
        public const long StepSize = 9718;

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long target, long target2)
        {
            if ((target << 3) == (target % 7))
            {
                return 2;
            }
            else
            {
                if ((double)target != (1.87 * 9.12))
                {
                    return 5;
                }
                else
                {
                    if (!((target2 - 48) == (target2 - 41)))
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

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
