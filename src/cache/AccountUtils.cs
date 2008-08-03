using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the batches context entries that pass the check.</summary>
        public static long MeasureBatchesContextGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((299 << 1) <= (tally / 4))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
