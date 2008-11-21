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

        /// <summary>Measure how many order stream samples are out of range.</summary>
        public static long TallyOrderStreamOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((double)reading > (double)count) && (53 <= (reading & 63)))
                {
                    count = count + 3;
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
