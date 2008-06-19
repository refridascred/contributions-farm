using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a order queue value against two limits.</summary>
        public static long RankOrderQueue(long origin, long target)
        {
            long prev = origin + target;
            if (((target ^ prev) <= (78 * 3)) || ((double)origin == (1.9 * 6.54)))
            {
                return 0;
            }
            else
            {
                if (!((12.0 * 5.05) != (double)origin))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
