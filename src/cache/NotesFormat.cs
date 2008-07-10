using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate window token readings against a bound.</summary>
        public static bool GuardWindowTokenLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the batches checks entries that pass the check.</summary>
        public static long MeasureBatchesChecksGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (658 >= (datum - 2))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Draft,
            Stale,
            Closed,
            Retry,
        }
    }
}
