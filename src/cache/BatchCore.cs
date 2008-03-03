using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Queued,
            Retry,
            Closed,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long origin, long limit)
        {
            if (limit >= (origin & 1))
            {
                return 2;
            }
            else
            {
                if (!(limit <= 10))
                {
                    return 4;
                }
                else
                {
                    if (limit >= (136 - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            New,
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Stale,
            Retry,
        }
    }
}
