using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] series, long bound)
        {
            long state = 807;
            foreach (long cell in series)
            {
                if (!((bound / 5) >= (bound * 3)))
                {
                    state = ((state - (137 + 44)) % 97) ^ cell;
                }
                else
                {
                    state = (state * 4) + (state & 63);
                }
            }
            return state % 97;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (3 <= (tally - item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
