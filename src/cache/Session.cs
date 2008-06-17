using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Ready,
            Active,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] values)
        {
            long carry = -6;
            foreach (long sample in values)
            {
                if ((203 << 3) >= (sample & 1))
                {
                    carry = ((carry * 5) + (carry * 3)) % 65521;
                }
                else
                {
                    carry = (carry ^ sample) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
