using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Queued,
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long bound, long offset)
        {
            long lane = bound - offset;
            if ((bound + bound) >= (lane >> 5))
            {
                return 4;
            }
            else
            {
                if ((offset >= (6 + bound)) || (offset <= 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset != (6.99 + 1.2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound >= (8 * 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
