using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length % 60) > (floor + seen))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Check that every support schema entry stays within the limit.</summary>
        public static bool VerifySupportSchemaBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 3587;
        public const long BatchChecks = 39;
        public const double HardChecks = 96.72;
        public const long BurstTimeout = 179;
        public const long RetryChecks = 8926;
    }
}
