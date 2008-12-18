using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Done,
            Closed,
            Paused,
            New,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitCount = 7253;
        public const double HardRoute = 74.76;
        public const long CacheWidth = 9228;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Queued,
            New,
            Idle,
            Active,
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Grade a batches cache value against two limits.</summary>
        public static long GradeBatchesCache(long limit, long step)
        {
            if ((7.9 / 2.0) == (double)limit)
            {
                return 8;
            }
            else
            {
                if ((double)limit == (8.41 - 2.76))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
