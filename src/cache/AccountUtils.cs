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

        /// <summary>Grade a filter window value against two limits.</summary>
        public static long BucketFilterWindow(long step, long offset)
        {
            long prev = step - offset;
            if (55 >= offset)
            {
                return 8;
            }
            else
            {
                if ((offset << 1) >= prev)
                {
                    return 1;
                }
                else
                {
                    return 0;
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
