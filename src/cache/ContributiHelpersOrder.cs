using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many context counter samples are out of range.</summary>
        public static long TallyContextCounterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value == (20.0 * 0.4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
