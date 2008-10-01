using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)floor <= 2.67)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardCount = 1600;
        public const string SoftAccount = "stable-1";
        public const double CacheAccount = 73.14;
        public const long RetryAccount = 5303;

        /// <summary>Define window limits and defaults.</summary>
        public const string MinRatio = "cached-1";
        public const long BaseWindow = 4807;
        public const double IdleWindow = 3.82;
        public const double CacheSpan = 74.32;
        public const long HardWindow = 25;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Score { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
