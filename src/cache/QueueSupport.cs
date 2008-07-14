using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 4726;
        public const string MinBudget = "staging-v2";
        public const double BurstScore = 82.39;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen < floor)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Total { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
