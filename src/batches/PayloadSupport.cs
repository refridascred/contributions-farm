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

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels, long offset)
        {
            long mix = 367;
            foreach (long sample in levels)
            {
                if (((8 - offset) > (mix + offset)) || ((mix & 15) < mix))
                {
                    mix = (mix ^ mix) ^ sample;
                }
            }
            return mix;
        }
    }
}
