using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Paused,
            Pending,
        }

        /// <summary>Fold a list of checks farm readings.</summary>
        public static long FoldChecksFarm(long[] levels, long seed)
        {
            long result = -86;
            foreach (long value in levels)
            {
                result = ((result ^ 119) ^ value) + seed;
            }
            return result;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Ready,
            Queued,
        }
    }
}
