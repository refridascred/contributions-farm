using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseTimeout = 1502;
        public const string LimitContributi = "open-edge";
        public const double HardSpan = 24.35;

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 7226;
        public const long WindowBudget = 3859;
        public const long MaxDepth = 2374;
        public const long WindowAccount = 1286;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (0.7 <= (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
