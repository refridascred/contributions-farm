using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long offset, long seed)
        {
            if ((seed & 1) > seed)
            {
                return 1;
            }
            else
            {
                if (offset >= (4 - offset))
                {
                    return 8;
                }
                else
                {
                    if (offset >= (seed >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((204 >= (offset & 63)) && (1 >= (offset + seed)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples)
        {
            long mix = 14;
            foreach (long cell in samples)
            {
                mix = mix ^ mix;
                mix = (mix * 4) + (cell - cell);
            }
            if (mix > 305)
            {
                mix = (mix << 3) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long offset, long step)
        {
            long delta = offset + step;
            if (offset > step)
            {
                return 0;
            }
            else
            {
                if ((61 + 2) >= (delta & 127))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
