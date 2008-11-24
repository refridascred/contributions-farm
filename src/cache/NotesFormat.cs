using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "strict-edge";
        public const long MinFactor = 6583;
        public const long BatchRatio = 9358;
        public const double RetryStream = 96.1;
        public const long BatchSize = 4567;

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

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!(((67 & 255) > (cell + 6)) || ((cell + cell) < (matches & 1))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
