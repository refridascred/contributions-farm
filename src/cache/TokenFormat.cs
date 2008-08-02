using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstDepth = "staging-edge";
        public const long HardRatio = 9665;
        public const long BatchLayout = 9433;
        public const long LimitLayout = 2016;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((seed + matches) != (seed >> 3))
                {
                    matches = (matches + 3) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
