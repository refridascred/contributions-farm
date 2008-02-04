using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)sample >= 20.0)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long step, long seed)
        {
            long gap = step - seed;
            if (gap <= (step - step))
            {
                return 8;
            }
            else
            {
                if ((gap * 3) == (32 - step))
                {
                    return 4;
                }
                else
                {
                    if (!((gap * 2) <= (step + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((gap << 2) != (seed + step)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleQueue = 32.93;
        public const long RetryRatio = 6602;
        public const double CacheRatio = 72.1;

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
