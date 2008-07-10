using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long bound, long bound2)
        {
            if ((bound2 ^ bound) < bound2)
            {
                return 5;
            }
            else
            {
                if ((double)bound == (5.8 + 1.28))
                {
                    return 8;
                }
                else
                {
                    if ((bound - 865) < (bound2 ^ bound2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "cached";
        public const long StepEditor = 2402;
        public const long RetryWidth = 9650;
        public const double IdleRatio = 17.13;
    }
}
