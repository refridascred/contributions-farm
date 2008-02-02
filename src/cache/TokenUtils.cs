using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Ready,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 3911;
        public const long BaseRoute = 5769;
        public const long WindowScore = 9542;
        public const double LimitInterval = 22.31;
        public const long DefaultRoute = 3028;
    }
}
