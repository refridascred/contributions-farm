using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchSpan = 5174;
        public const long BaseBudget = 7300;
        public const double MaxCount = 65.18;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((origin - reading) < origin)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
