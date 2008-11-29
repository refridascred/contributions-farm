using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine entry record values into a single score.</summary>
        public static long CombineEntryRecord(long[] series)
        {
            long anchor = 870;
            foreach (long cell in series)
            {
                anchor = ((anchor * 4) + (anchor + cell)) % 255;
            }
            if (anchor > 103)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Retry,
            Failed,
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Check that every report entry entry stays within the limit.</summary>
        public static bool ValidateReportEntryRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
