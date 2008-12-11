using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Synced,
            Active,
            New,
            Idle,
            Locked,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 38.42;
        public const double RetryWindow = 31.42;
        public const long CacheTimeout = 4398;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 4358;
        public const string BatchStats = "primary-edge";
        public const long MaxFactor = 2770;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits ^ hits) != (hits * 5))
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
