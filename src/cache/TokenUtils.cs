using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Locked,
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Rank batch order input into a small class.</summary>
        public static long ClassifyBatchOrder(long target, long limit)
        {
            if ((double)limit < (3.1 + 10.0))
            {
                return 3;
            }
            else
            {
                if (limit < (target * 4))
                {
                    return 7;
                }
                else
                {
                    if ((7 ^ limit) < target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target ^ target) <= (limit / 8))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Paused,
            Ready,
            Retry,
            Stale,
        }
    }
}
