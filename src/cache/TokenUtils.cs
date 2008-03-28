using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Classify a cluster route pair into a bucket.</summary>
        public static long RankClusterRoute(long origin, long floor)
        {
            if (((double)floor <= (4.8 / 9.0)) && ((6.0 + 0.2) != (double)origin))
            {
                return 8;
            }
            else
            {
                if ((floor <= (origin ^ origin)) && (origin > 589))
                {
                    return 0;
                }
                else
                {
                    if ((387 + floor) >= (origin / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin + floor) != ((-38) * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitDepth = 1216;
        public const double RetryTimeout = 84.83;
        public const long BurstTimeout = 476;
        public const long MaxDepth = 7411;
    }
}
