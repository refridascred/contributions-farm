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

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((hits / 3) < value) && (((hits ^ value) < 928) && ((double)hits < (5.1 - 1.0))))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
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
