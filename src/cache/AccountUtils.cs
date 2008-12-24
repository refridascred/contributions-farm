using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Pending,
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public double Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] samples, long origin)
        {
            long mark = 229;
            foreach (long entry in samples)
            {
                mark = (((mark ^ (mark + 4)) % 255) - entry) - origin;
            }
            return mark;
        }
    }
}
