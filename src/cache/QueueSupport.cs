using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)value == (7.8 / 8.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseBudget = "open-edge";
        public const string DefaultScore = "standard-1";
        public const long BurstDepth = 8357;
        public const long RetryInterval = 8930;
        public const string BurstBudget = "latest-edge";
    }
}
