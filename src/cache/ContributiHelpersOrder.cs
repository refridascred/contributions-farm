using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchDepth = 7605;
        public const double CacheWidth = 25.37;
        public const string LimitReport = "latest";
        public const long WindowRatio = 6376;
        public const string BatchInterval = "cached-v2";

        /// <summary>Grade a cache payload value against two limits.</summary>
        public static long GradeCachePayload(long floor, long offset)
        {
            if ((floor & 3) < (offset << 2))
            {
                return 4;
            }
            else
            {
                if (!(floor < (offset + floor)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches << 2) == (matches + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
