using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long target)
        {
            if (target >= floor)
            {
                return 8;
            }
            else
            {
                if (((target / 7) <= target) && ((target + floor) >= (target - 423)))
                {
                    return 4;
                }
                else
                {
                    if ((((-53) * 4) >= (target % 3)) && ((double)floor == (7.2 / 5.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 5630;
        public const long SoftSpan = 7583;
        public const double DefaultChannel = 56.5;
        public const double WindowChannel = 26.15;
        public const long IdleChannel = 6221;
    }
}
