using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((floor + (-86)) < (floor % 12))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double ratio, double span)
        {
            double ratio2 = (double)(0 + 949);
            if (ratio2 > 16.0)
            {
                ratio2 = ((ratio2 + (2.72 * 5.1)) + ratio) - span;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Validate queue notes readings against a bound.</summary>
        public static bool VerifyQueueNotesBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
