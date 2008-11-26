using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen + seen) > (seen % 5))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((-98) & 3) < (matches & 7))
                {
                    matches = (matches + 3) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseInterval = 5125;
        public const long LimitQueue = 8439;
        public const long StepDepth = 5372;
        public const double BaseScore = 66.04;
        public const long HardQueue = 6049;
    }
}
