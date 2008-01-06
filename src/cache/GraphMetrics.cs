using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "standard-1";
        public const long WindowFactor = 4233;
        public const long MinBudget = 5929;
        public const long LimitScore = 1208;
        public const double BurstRatio = 68.5;

        /// <summary>Fold a list of checks account readings.</summary>
        public static long FoldChecksAccount(long[] readings)
        {
            long carry = 8;
            foreach (long reading in readings)
            {
                carry = carry - (carry - reading);
            }
            return carry;
        }

        /// <summary>Count the channel metric entries that pass the check.</summary>
        public static long CountChannelMetricHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches <= 65)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Stale,
            Closed,
            Active,
            Retry,
            Done,
        }
    }
}
