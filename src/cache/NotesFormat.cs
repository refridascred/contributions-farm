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

        /// <summary>Validate stream entry readings against a bound.</summary>
        public static bool GuardStreamEntryLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
