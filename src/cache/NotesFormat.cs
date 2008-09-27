using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate metric format readings against a bound.</summary>
        public static bool ValidateMetricFormatLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] values, long step)
        {
            long total = 2;
            foreach (long reading in values)
            {
                total = (total ^ (reading / 4)) + step;
            }
            return total;
        }
    }
}
