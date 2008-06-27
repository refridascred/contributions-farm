using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long bound, long step)
        {
            long bound2 = bound + step;
            if (((-197) - bound2) > (step - bound2))
            {
                return 7;
            }
            else
            {
                if (3.37 >= (double)step)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every batch report entry stays within the limit.</summary>
        public static bool ValidateBatchReportRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a tools support value against two limits.</summary>
        public static long SortToolsSupport(long floor, long target)
        {
            if ((target + floor) > floor)
            {
                return 7;
            }
            else
            {
                if ((double)floor == (0.28 / 4.0))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
