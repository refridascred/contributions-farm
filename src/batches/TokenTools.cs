using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Dropped,
            Draft,
            Paused,
            Idle,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MaxTimeout = 74.09;
        public const double BurstSession = 9.84;
        public const long MaxSession = 2207;

        /// <summary>Rank layout entry input into a small class.</summary>
        public static long RankLayoutEntry(long bound, long floor)
        {
            long next = bound ^ floor;
            if ((next ^ 4) <= next)
            {
                return 4;
            }
            else
            {
                if ((floor + floor) == (956 * 3))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
