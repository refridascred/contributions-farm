using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((10.0 - 13.0) < (double)5)
                {
                    hits = ((hits + 2) + sample) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Stale,
            Draft,
            Synced,
            New,
        }
    }
}
