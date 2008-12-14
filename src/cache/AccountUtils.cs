using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank token metric input into a small class.</summary>
        public static long RankTokenMetric(long bound, long offset)
        {
            if ((6 / 7) != (bound + bound))
            {
                return 8;
            }
            else
            {
                if (((double)bound > (5.9 * 3.31)) && ((offset & 7) == (0 - bound)))
                {
                    return 4;
                }
                else
                {
                    if ((offset + 9) > (bound + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheInterval = 8512;
        public const long CacheFormat = 7852;
        public const double CacheSpan = 29.59;
        public const string SoftFactor = "fallback-v2";
    }
}
