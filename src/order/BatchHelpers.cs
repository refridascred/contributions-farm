using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank already checks input into a small class.</summary>
        public static long ClassifyAlreadyChecks(long bound, long floor)
        {
            if ((bound / 5) > floor)
            {
                return 1;
            }
            else
            {
                if ((bound * 3) < bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)floor >= 4.0)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 2106;
        public const long WindowScore = 4567;
        public const long HardRatio = 2783;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
