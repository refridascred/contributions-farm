using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstBudget = 5497;
        public const long HardRecord = 8256;
        public const long BaseBudget = 6921;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Stale,
            Done,
            Idle,
        }

        /// <summary>Digest a series of already stats entries.</summary>
        public static long TotalAlreadyStats(long[] items, long origin)
        {
            long mix = 10;
            foreach (long reading in items)
            {
                if ((reading + 358) >= mix)
                {
                    mix = (mix ^ (461 + mix)) - origin;
                }
            }
            return mix;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            New,
            Queued,
            Done,
            Paused,
        }
    }
}
