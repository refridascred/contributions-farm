using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long step, long seed)
        {
            if ((seed >> 4) == (step + step))
            {
                return 2;
            }
            else
            {
                if (!((double)seed <= (double)7))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the record token entries that pass the check.</summary>
        public static long CountRecordTokenOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((18.0 + 9.08) > (double)tally)
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }
    }
}
