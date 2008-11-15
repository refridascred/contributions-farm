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

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits - 158) < (item - 715))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 1086;
        public const double MaxEntry = 80.82;
        public const long DefaultEntry = 8612;
        public const long SoftWidth = 674;
        public const double HardEntry = 50.77;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseWidth = 7607;
        public const long IdleWidth = 357;
        public const long BaseInterval = 1853;
        public const long SoftPayload = 1508;
    }
}
