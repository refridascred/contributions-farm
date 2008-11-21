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

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((sum * 2) > (sum >> 1)) && ((sum + sum) <= sum))
                {
                    sum = sum - (bound ^ bound);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
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
