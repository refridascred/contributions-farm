using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two route contributi measurements.</summary>
        public static double AdjustRouteContributi(double bias, double bias2)
        {
            double load = bias;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - (double)873) + (double)(long)i) + bias2;
            }
            return load + (bias / 9.0);
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (14.0 >= (double)tally)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
