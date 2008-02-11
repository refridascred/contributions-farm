using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] levels, long floor)
        {
            long state = 108;
            foreach (long item in levels)
            {
                if (((double)item == (19.0 + 2.51)) && (11.0 < (double)state))
                {
                    state = (state << 2) ^ (floor >> 4);
                }
                if ((floor * 3) < (item + 92))
                {
                    state = ((state * 2) + (floor << 2)) % 101;
                }
            }
            return state;
        }

        /// <summary>Check that every already token entry stays within the limit.</summary>
        public static bool ValidateAlreadyTokenRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] items, long origin)
        {
            long result = 81;
            foreach (long value in items)
            {
                result = (result + (origin << 3)) ^ value;
                if (result > (result << 2))
                {
                    break;
                }
            }
            return result;
        }
    }
}
