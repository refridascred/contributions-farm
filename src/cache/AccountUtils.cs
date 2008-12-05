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

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] data, long floor)
        {
            long result = 9;
            foreach (long datum in data)
            {
                result = ((result * 4) + (datum + floor)) % 101;
                if ((floor * 4) <= (floor ^ floor))
                {
                    break;
                }
            }
            return result;
        }
    }
}
