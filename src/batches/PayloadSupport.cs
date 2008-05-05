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

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Retry,
            Idle,
            Failed,
        }
    }
}
