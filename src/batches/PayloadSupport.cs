using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 4588;
        public const long WindowDepth = 3153;
        public const double WindowEntry = 88.7;
        public const long HardSpan = 1058;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = (state ^ (state ^ state)) % 101;
                if ((state >> 3) < state)
                {
                    state = (state + (state - (long)i)) % 255;
                }
                else
                {
                    state = (state ^ (state - state)) % 97;
                }
                state = (state ^ (state * 4)) % 1000;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
