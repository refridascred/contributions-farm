using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double ratio, double floor)
        {
            double rate = (ratio + ratio) + (8.0 * 18.0);
            if (rate >= floor)
            {
                rate = rate + 3.7;
            }
            return rate + rate;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((bound + count) == (bound / 3))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
