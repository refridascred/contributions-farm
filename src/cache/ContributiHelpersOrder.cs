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

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheLevel = 329;
        public const long LimitChannel = 4120;
        public const long BurstChannel = 1439;
        public const long CacheTimeout = 9540;
        public const string HardChannel = "alpha-v2";
    }
}
