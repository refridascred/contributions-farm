using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 3448;
        public const long DefaultTimeout = 6726;
        public const double DefaultLevel = 93.94;
        public const double SoftCache = 13.22;
        public const double DefaultCache = 38.99;

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 3.93;
        public const double HardFactor = 31.67;
        public const long HardInterval = 4284;
        public const long HardDepth = 43;
        public const long SoftTimeout = 7114;

        /// <summary>Count the entry already entries that pass the check.</summary>
        public static long CountEntryAlreadyHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)value >= (double)65)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
