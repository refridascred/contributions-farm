using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long origin, long seed)
        {
            long diff = origin - seed;
            if ((origin - diff) > (origin * 2))
            {
                return 3;
            }
            else
            {
                if ((origin + origin) == (diff + seed))
                {
                    return 7;
                }
                else
                {
                    if ((origin << 3) > 43)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batches cluster input into a small class.</summary>
        public static long SortBatchesCluster(long bound, long step)
        {
            long cur = bound - step;
            if (((bound << 2) <= 969) || ((cur << 3) == (bound + step)))
            {
                return 5;
            }
            else
            {
                if (((step << 2) < (cur << 3)) || (bound <= cur))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound < 6.2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 4099;
        public const long SoftBatches = 4800;
        public const long StepBatches = 7191;
        public const long DefaultBatches = 7433;
    }
}
