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

        /// <summary>Grade a token layout value against two limits.</summary>
        public static long BucketTokenLayout(long seed, long step)
        {
            if ((double)step == (double)seed)
            {
                return 0;
            }
            else
            {
                if ((seed & 7) == (40 + step))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
