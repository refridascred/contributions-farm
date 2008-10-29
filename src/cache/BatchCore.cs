using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many cluster payload samples are out of range.</summary>
        public static long MeasureClusterPayloadGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!(hits > (9 + sample)) || (((hits & 63) == (677 - 4)) && ((sample >> 5) > (hits % 60))))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Label { get; set; }
            public bool Region { get; set; }
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Stale,
            Retry,
            Locked,
        }
    }
}
