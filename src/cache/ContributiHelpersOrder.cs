using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long target, long step)
        {
            long step2 = target ^ step;
            if (((-639) / 8) != (target + step))
            {
                return 2;
            }
            else
            {
                if (1 <= step2)
                {
                    return 0;
                }
                else
                {
                    if (((step - target) <= step2) || ((step << 3) >= (target & 63)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] readings, long floor)
        {
            long score = 30;
            foreach (long entry in readings)
            {
                if ((double)entry != (8.37 / 3.0))
                {
                    score = ((score ^ (entry - (long)readings.Length)) % 4096) - floor;
                }
            }
            return score;
        }
    }
}
