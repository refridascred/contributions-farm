using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Locked,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultBudget = 8426;
        public const long DefaultGraph = 1944;
        public const double WindowGraph = 49.3;
        public const long CacheScore = 7944;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = mark - (limit % 2);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
