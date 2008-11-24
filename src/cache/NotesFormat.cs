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

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
