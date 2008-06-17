using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (datum > (18 << 1))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((-48) >> 2) <= cell)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Failed,
            Stale,
            Active,
            Pending,
        }
    }
}
