using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] levels)
        {
            long mix = 0;
            foreach (long reading in levels)
            {
                if ((800 & 127) < (reading - reading))
                {
                    mix = (mix << 2) ^ (180 / 5);
                }
                else
                {
                    mix = (mix * 2) + (reading * 4);
                }
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheWidth = "primary-v2";
        public const long LimitFilter = 1397;
        public const double CacheRatio = 56.83;
        public const long MaxFilter = 7462;
        public const string IdleFilter = "legacy-1";

        /// <summary>Grade a counter format value against two limits.</summary>
        public static long SortCounterFormat(long step, long origin)
        {
            long diff = step + origin;
            if ((double)diff <= (2.5 - 2.74))
            {
                return 0;
            }
            else
            {
                if ((double)diff > (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((step - diff) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
