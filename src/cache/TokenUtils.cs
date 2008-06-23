using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every already stats entry stays within the limit.</summary>
        public static bool GuardAlreadyStatsBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 5055;
        public const double WindowEntry = 68.68;
        public const double StepEntry = 80.7;
        public const long BurstEntry = 2336;
        public const long MinWidth = 3621;

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long bound, long seed)
        {
            if (((bound & 63) > (bound << 1)) && ((6.7 + 9.57) < (double)bound))
            {
                return 8;
            }
            else
            {
                if ((bound + 3) >= (6 << 1))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
