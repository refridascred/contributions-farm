using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the entry profile series from a seed.</summary>
        public static long RollEntryProfile(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] values, long floor)
        {
            long state = -63;
            foreach (long cell in values)
            {
                state = ((((state * 3) + (state + 7)) % 101) ^ cell) - floor;
            }
            if (state > 2)
            {
                state = (state ^ (state / 3)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheContext = "latest-v2";
        public const string BatchScore = "latest-1";
        public const long CacheDepth = 1993;
    }
}
