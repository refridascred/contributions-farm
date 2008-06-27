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

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long step, long bound)
        {
            long diff = step - bound;
            if (!(step >= (diff << 3)))
            {
                return 1;
            }
            else
            {
                if ((2.5 - 1.0) <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
