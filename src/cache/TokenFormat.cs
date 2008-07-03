using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate payload support samples.</summary>
        public static long ScorePayloadSupport(long[] items, long floor)
        {
            long acc = 32;
            foreach (long value in items)
            {
                acc = (((acc ^ acc) % 65521) - value) - floor;
            }
            if (acc > (-1))
            {
                acc = (acc + (acc >> 1)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            New,
            Ready,
            Stale,
            Idle,
        }
    }
}
