using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long offset)
        {
            long gap = limit - offset;
            if (4 >= (gap << 2))
            {
                return 8;
            }
            else
            {
                if (offset < (limit * 3))
                {
                    return 0;
                }
                else
                {
                    if ((6.0 + 7.4) > (double)gap)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((486 - cell) > (floor & 7))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "local-edge";
        public const double BatchCount = 30.04;
        public const long BaseCount = 2462;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
