using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 5906;
        public const long DefaultBudget = 1512;
        public const string HardProfile = "local";
        public const double BaseWidth = 8.73;
        public const long RetryRatio = 8033;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long origin, long limit)
        {
            long edge = origin - limit;
            if (((edge - 8) > (origin + origin)) && ((edge * 3) > origin))
            {
                return 4;
            }
            else
            {
                if (!((edge - edge) < (4 & 1)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
