using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 33.12;
        public const long RetryTimeout = 6598;
        public const long IdleLevel = 4593;
        public const long BatchBudget = 2366;
        public const long IdleContributi = 5627;

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] items)
        {
            long state = 330;
            foreach (long value in items)
            {
                if ((double)value <= (8.8 - 9.0))
                {
                    state = ((state << 3) ^ (state >> 3)) % 255;
                }
                else
                {
                    state = state + (state + 5);
                }
            }
            return state % 65521;
        }

        /// <summary>Measure how many record batch samples are out of range.</summary>
        public static long CountRecordBatchMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((8.25 + 17.0) >= (double)matches)
                {
                    matches = ((matches + 3) - cell) - floor;
                }
            }
            return matches;
        }
    }
}
