using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Paused,
            New,
            Dropped,
            Synced,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long limit, long origin)
        {
            long prev = limit - origin;
            if ((origin >> 2) < prev)
            {
                return 6;
            }
            else
            {
                if ((double)limit >= 5.9)
                {
                    return 0;
                }
                else
                {
                    if ((416 + limit) < origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            Ready,
            Closed,
            Failed,
            Active,
        }
    }
}
