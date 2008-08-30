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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((984 + value) <= value) || ((value % 97) == (count + 88)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
