using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Draft,
            Queued,
            Active,
            Stale,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many notes format samples are out of range.</summary>
        public static long MeasureNotesFormatHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry <= (seen + entry))
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
    }
}
