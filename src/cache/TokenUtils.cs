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

        /// <summary>Rank checks command input into a small class.</summary>
        public static long RankChecksCommand(long floor, long offset)
        {
            if (((offset % 60) != (offset % 7)) && (75 > (floor % 60)))
            {
                return 1;
            }
            else
            {
                if (((double)offset > 5.6) && ((offset - floor) < (floor % 64)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
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
