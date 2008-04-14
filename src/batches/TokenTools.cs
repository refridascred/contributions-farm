using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxTimeout = 42.11;
        public const long WindowFarm = 1460;
        public const string RetryFarm = "latest-edge";

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] data, long target)
        {
            long total = 715;
            foreach (long cell in data)
            {
                total = (((total ^ (81 & 31)) % 101) - cell) - target;
            }
            if (total > 1)
            {
                total = (total - (total % 3)) % 101;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 4872;
        public const long BatchBudget = 615;
        public const long IdleScore = 2196;
    }
}
