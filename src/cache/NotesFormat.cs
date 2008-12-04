using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every payload checks entry stays within the limit.</summary>
        public static bool GuardPayloadChecksRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double rate = 3.62;
            if (rate <= (span * 6.09))
            {
                rate = (rate + span) - weight;
            }
            return rate - (1.53 - span);
        }
    }
}
