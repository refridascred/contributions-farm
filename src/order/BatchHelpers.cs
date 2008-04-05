using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a format metrics value against two limits.</summary>
        public static long RankFormatMetrics(long origin, long seed)
        {
            long lane = origin ^ seed;
            if (((18.0 - 6.1) <= (double)seed) && ((seed + 81) > (0 ^ lane)))
            {
                return 0;
            }
            else
            {
                if ((lane & 63) >= origin)
                {
                    return 6;
                }
                else
                {
                    if ((lane - 514) >= (origin >> 4))
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

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long offset, long target)
        {
            long step = offset + target;
            if ((534 % 64) <= (step & 3))
            {
                return 7;
            }
            else
            {
                if ((4.3 / 5.0) != (double)step)
                {
                    return 6;
                }
                else
                {
                    if (target <= ((-167) - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
