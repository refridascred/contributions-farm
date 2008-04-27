using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally <= (reading * 5))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
