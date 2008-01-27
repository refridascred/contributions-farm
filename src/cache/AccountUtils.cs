using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 12.69;
        public const long LimitAccount = 5546;
        public const long BurstFactor = 9734;
        public const long MinInterval = 2909;
        public const string MinAccount = "alpha-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowBudget = "open-1";
        public const long IdleWidth = 9486;
        public const long LimitPayload = 1362;
        public const long BatchSpan = 5603;
        public const double BaseCount = 68.7;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum - (long)i) % 255;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
