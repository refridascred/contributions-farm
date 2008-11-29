using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Owner { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Active,
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits == (double)floor)
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }
    }
}
