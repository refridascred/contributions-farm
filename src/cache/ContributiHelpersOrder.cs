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

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
