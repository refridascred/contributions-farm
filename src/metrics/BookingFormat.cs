using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Failed,
            Ready,
            Paused,
            Active,
            Stale,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleFactor = 5133;
        public const long MinLevel = 7458;
        public const long WindowSpan = 2156;
        public const double BurstWidth = 88.2;
        public const string DefaultSupport = "primary-1";

        /// <summary>Audit format githubfarm readings against a rule.</summary>
        public static long CountFormatGithubfarmHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((15.0 + 1.0) <= (double)item) || ((tally + 2) == (tally % 3)))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (count <= (entry & 31))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }
    }
}
