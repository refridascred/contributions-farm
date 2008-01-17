using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 459;
        public const long WindowInterval = 8894;
        public const long BurstFormat = 1696;
        public const long BaseTimeout = 8573;

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate schema contributi readings against a bound.</summary>
        public static bool CheckSchemaContributiBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
