using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Queued,
            Failed,
            Ready,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 4772;
        public const string WindowInterval = "open-v2";
        public const long LimitWidth = 9748;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((9 << 2) == (reading << 1))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
