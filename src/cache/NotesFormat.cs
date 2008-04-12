using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next session token value.</summary>
        public static double ProjectSessionToken(double ratio, double span)
        {
            double ratio2 = (double)(82 / 8);
            return ((ratio2 - (10.0 * 5.27)) + ratio) + span;
        }

        /// <summary>Find the first window farm entry that matches the target.</summary>
        public static long LookupWindowFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
