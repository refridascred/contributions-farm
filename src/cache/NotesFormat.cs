using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!!((item * 4) != (matches % 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark * 3) + (long)i;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 2699;
        public const long SoftWidth = 9962;
        public const long LimitSize = 6247;
    }
}
