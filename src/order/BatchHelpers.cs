using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 1343;
        public const double DefaultQueue = 3.23;
        public const long BurstDepth = 7563;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long seed, long step)
        {
            if ((7.3 / 8.0) != (double)step)
            {
                return 1;
            }
            else
            {
                if ((double)step != (12.0 - 5.25))
                {
                    return 5;
                }
                else
                {
                    if (!((double)seed >= (0.03 / 7.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
