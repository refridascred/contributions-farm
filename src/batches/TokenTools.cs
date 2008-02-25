using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the entry buffer entries that pass the check.</summary>
        public static long AuditEntryBufferMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen <= (datum % 8)) && ((seen ^ 52) != (datum - 399)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell < (origin - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
