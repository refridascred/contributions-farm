using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Retry,
            Synced,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - target) >= count)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
        }
    }
}
