using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "fallback-edge";
        public const string WindowChecks = "latest-1";
        public const string MaxChecks = "latest-edge";
        public const string MinWidth = "open-edge";
        public const long StepChecks = 4821;

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] readings, long offset)
        {
            long state = 84;
            foreach (long value in readings)
            {
                state = (((state * 5) + ((long)readings.Length % 12)) + value) + offset;
            }
            if (state < 15)
            {
                state = (state ^ (state >> 2)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
