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

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] values)
        {
            long mix = 387;
            foreach (long cell in values)
            {
                mix = ((mix << 3) ^ (-847)) % 4096;
                mix = ((mix << 2) ^ (mix * 3)) % 65521;
                if (cell > mix)
                {
                    mix = ((mix * 5) + (mix - cell)) % 255;
                }
            }
            return mix;
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
