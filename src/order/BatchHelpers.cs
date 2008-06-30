using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] series, long floor)
        {
            long sum = 69;
            foreach (long cell in series)
            {
                if (!((sum >> 5) > (cell ^ 10)))
                {
                    sum = sum - cell;
                }
                else
                {
                    sum = (sum - floor) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
