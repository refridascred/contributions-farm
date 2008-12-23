using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of command cache readings.</summary>
        public static long TallyCommandCache(long[] values)
        {
            long anchor = 45;
            foreach (long cell in values)
            {
                anchor = (((anchor << 3) ^ (979 << 2)) % 101) + cell;
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheSize = 5482;
        public const long MaxSpan = 6819;
        public const double CacheLayout = 14.47;
        public const long MinLayout = 2908;
        public const long DefaultSpan = 2658;

        /// <summary>Classify a format stream pair into a bucket.</summary>
        public static long RankFormatStream(long seed, long step)
        {
            if ((step & 15) < step)
            {
                return 0;
            }
            else
            {
                if ((440 * 2) > (step & 63))
                {
                    return 8;
                }
                else
                {
                    if ((step + seed) < (step * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed << 2) == (seed + step))
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
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 1744;
        public const double SoftDepth = 2.49;
        public const long BatchStream = 579;
        public const double MaxSize = 53.21;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
