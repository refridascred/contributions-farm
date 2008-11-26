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

        /// <summary>Audit report layout readings against a rule.</summary>
        public static long CountReportLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((hits <= (entry >> 3)) || ((entry - 6) >= hits)) || !((hits % 97) != (entry % 60)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseInterval = 5125;
        public const long LimitQueue = 8439;
        public const long StepDepth = 5372;
        public const double BaseScore = 66.04;
        public const long HardQueue = 6049;
    }
}
