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

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseSize = 5337;
        public const string LimitRatio = "open-1";
        public const long HardCount = 1775;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
