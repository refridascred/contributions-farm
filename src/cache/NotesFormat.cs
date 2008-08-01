using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell & 15) != (count + cell))
                {
                    count = (count + 3) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
