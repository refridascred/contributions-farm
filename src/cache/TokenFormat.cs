using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = total + total;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 5.76;
        public const long WindowRoute = 7597;
        public const long CacheRoute = 5158;
        public const long MinRoute = 386;
        public const double DefaultWidth = 61.15;

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 3847;
        public const long LimitSpan = 3737;
        public const double MaxDepth = 42.7;
    }
}
