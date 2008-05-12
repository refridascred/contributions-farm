using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the contributi stream entries that pass the check.</summary>
        public static long CountContributiStreamHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!(((reading + reading) <= (matches & 31)) && ((double)matches < (11.0 + 5.62))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next checks order value.</summary>
        public static double BlendChecksOrder(double bias, double floor)
        {
            double mean = 1.1;
            if (mean <= bias)
            {
                mean = (mean + mean) - floor;
            }
            else
            {
                mean = mean - mean;
            }
            return mean - (double)16;
        }
    }
}
