using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] series)
        {
            long anchor = 478;
            foreach (long cell in series)
            {
                anchor = anchor ^ (cell >> 3);
            }
            return anchor % 65521;
        }

        /// <summary>Count the counter format entries that pass the check.</summary>
        public static long CountCounterFormatGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen >> 1) >= (offset % 64))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 0.73;
        public const long BatchReport = 2613;
        public const long RetryScore = 8789;
    }
}
