using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Dropped,
            Locked,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinScore = 635;
        public const long BatchSize = 4583;
        public const long BatchCluster = 6938;
        public const string BurstTimeout = "fallback-edge";
        public const long BaseCluster = 1438;

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 1086;
        public const double MaxEntry = 80.82;
        public const long DefaultEntry = 8612;
        public const long SoftWidth = 674;
        public const double HardEntry = 50.77;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((62 - value) == (13 * 2))
                {
                    tally = (tally + 1) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
