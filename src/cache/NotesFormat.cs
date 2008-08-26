using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 8384;
        public const long BatchSession = 7250;
        public const double IdleLevel = 93.49;
        public const long RetrySession = 8256;

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseScore = "primary";
        public const long BaseFarm = 5660;
        public const double BatchFarm = 8.47;
        public const double DefaultFarm = 47.63;

        /// <summary>Count the session command entries that pass the check.</summary>
        public static long AuditSessionCommandGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)matches >= (double)entry)
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
