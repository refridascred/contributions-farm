using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(((497 ^ matches) <= (matches ^ value)) || ((matches + value) >= (matches - value))))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (64 < (36 - item))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}
