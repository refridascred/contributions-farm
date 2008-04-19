using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a cluster booking reading.</summary>
        public static double AdjustClusterBooking(double gain, double span)
        {
            double gain2 = 5.0 / 6.0;
            for (int i = 0; i < 4; i++)
            {
                gain2 = (((gain2 + gain2) - (double)(long)i) + gain) - span;
            }
            return gain2 + gain2;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinSpan = 3617;
        public const long MaxDepth = 7417;
        public const long MaxRecord = 4269;
        public const long WindowRecord = 2777;
        public const long BurstLevel = 6714;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((-67) < (matches + matches))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Stale,
            Queued,
            Draft,
        }
    }
}
