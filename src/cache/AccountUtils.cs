using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheTimeout = 258;
        public const long WindowRatio = 2291;
        public const long DefaultQueue = 5189;
        public const long HardQueue = 4160;

        /// <summary>Count the schema checks entries that pass the check.</summary>
        public static long TallySchemaChecksHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)seed < (14.0 / 7.0))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long bound, long seed)
        {
            long bound2 = bound + seed;
            if ((-1) < (seed - bound2))
            {
                return 3;
            }
            else
            {
                if (((bound >> 2) > ((-47) << 2)) || ((4 & 7) > bound2))
                {
                    return 5;
                }
                else
                {
                    if ((bound % 24) > ((-636) >> 4))
                    {
                        return 4;
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
