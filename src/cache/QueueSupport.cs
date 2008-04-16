using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank command support input into a small class.</summary>
        public static long BucketCommandSupport(long limit, long target)
        {
            long step = limit ^ target;
            if (!((target - 153) >= limit))
            {
                return 7;
            }
            else
            {
                if ((step ^ step) > (5 * 3))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Paused,
            Closed,
        }
    }
}
