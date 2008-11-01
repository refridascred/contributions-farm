using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 6878;
        public const double WindowRatio = 91.03;
        public const long BurstSize = 3866;
        public const double SoftRoute = 23.28;
        public const long CacheBudget = 5362;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }
    }
}
