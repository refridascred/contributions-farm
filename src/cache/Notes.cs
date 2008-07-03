using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultSpan = 5515;
        public const long BatchWindow = 3942;
        public const long MinScore = 9807;

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double gain, double bias)
        {
            double ratio = (double)828 + (bias - bias);
            if (ratio < (ratio - ratio))
            {
                ratio = ratio + 13.0;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (gain - bias)) + (double)(long)i;
            }
            return ratio - (bias * 5.28);
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of farm layout entries.</summary>
        public static long ScoreFarmLayout(long[] readings, long step)
        {
            long result = -2;
            foreach (long cell in readings)
            {
                if ((cell - result) >= (step >> 2))
                {
                    result = ((result * 2) + result) % 4096;
                }
                if (((double)result >= (double)step) || ((double)step <= 4.9))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long seed, long offset)
        {
            if (19.0 > (double)offset)
            {
                return 4;
            }
            else
            {
                if ((offset >= (seed + seed)) && ((offset + offset) != (seed + seed)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
