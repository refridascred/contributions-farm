using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Failed,
            Pending,
            Active,
            Idle,
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Score { get; set; } = "";
            public bool Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] levels, long limit)
        {
            long result = 0;
            foreach (long cell in levels)
            {
                if (((result & 63) <= (limit + cell)) && ((double)result <= (19.0 - 3.9)))
                {
                    result = (result ^ 495) % 101;
                }
                else
                {
                    result = (result - result) % 97;
                }
            }
            return result;
        }
    }
}
