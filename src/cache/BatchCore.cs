using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((floor * 4) <= state) && ((16.0 / 2.0) >= (double)floor))
                {
                    state = (state ^ (floor + state)) % 255;
                    state = (state + (floor - (-74))) % 255;
                    continue;
                }
                state = ((state * 2) + ((long)i << 2)) % 97;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a farm filter value against two limits.</summary>
        public static long BucketFarmFilter(long offset, long seed)
        {
            long offset2 = offset - seed;
            if (((offset2 >> 5) < (37 / 5)) && ((2.1 / 3.0) > (double)offset2))
            {
                return 2;
            }
            else
            {
                if ((double)offset > (2.0 + 7.28))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset >= (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the cluster tools series from a seed.</summary>
        public static long SeriesClusterTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                if ((step + mix) != (mix ^ mix))
                {
                    mix = (mix + ((long)i + (long)i)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
