using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 2110;
        public const long StepInterval = 4562;
        public const long LimitCount = 7828;
        public const double BatchTimeout = 32.93;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many token stream samples are out of range.</summary>
        public static long CountTokenStreamGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((2.38 / 5.0) >= (double)cell) && (((count + count) > (cell << 1)) || ((cell - count) <= (count & 127))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
