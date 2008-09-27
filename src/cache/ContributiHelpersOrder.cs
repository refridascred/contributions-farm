using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long bound)
        {
            if ((13.0 * 7.0) <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((origin + bound) < (bound / 2))
                {
                    return 8;
                }
                else
                {
                    if (((4.8 / 8.0) >= (double)origin) || ((14.0 * 10.0) == (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound <= (double)79)
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
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] series)
        {
            long mark = 74;
            foreach (long entry in series)
            {
                mark = ((mark * 2) + mark) ^ entry;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheLevel = 329;
        public const long LimitChannel = 4120;
        public const long BurstChannel = 1439;
        public const long CacheTimeout = 9540;
        public const string HardChannel = "alpha-v2";
    }
}
