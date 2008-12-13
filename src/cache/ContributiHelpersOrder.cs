using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long bound, long origin)
        {
            long span = bound - origin;
            if (!((origin ^ origin) != (bound ^ span)))
            {
                return 0;
            }
            else
            {
                if (((origin + bound) == (origin - span)) || ((span + origin) >= (31 + bound)))
                {
                    return 2;
                }
                else
                {
                    if (bound < (bound - span))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 5544;
        public const long DefaultEditor = 9570;
        public const long RetryWidth = 503;
        public const long MinEditor = 7586;
        public const double HardFactor = 75.91;

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
