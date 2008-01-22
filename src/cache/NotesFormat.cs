using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit record notes readings against a rule.</summary>
        public static long AuditRecordNotesMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(((669 & 63) != (item << 3)) && (((-8) + item) <= (item ^ 21))))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double ratio, double span)
        {
            double rate = (double)(-7) / 7.0;
            if (rate < ratio)
            {
                rate = rate - (rate + 8.5);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate - (span / 5.0);
        }
    }
}
