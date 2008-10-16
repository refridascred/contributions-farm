using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Dropped,
            Idle,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 2) ^ floor) % 97;
                if ((floor % 24) == (mix % 2))
                {
                    mix = mix + mix;
                    mix = ((mix * 3) + ((long)i + floor)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long bound, long offset)
        {
            if ((bound ^ bound) >= offset)
            {
                return 4;
            }
            else
            {
                if ((16.0 >= (double)offset) || (bound >= offset))
                {
                    return 8;
                }
                else
                {
                    if ((bound > (offset % 5)) || ((double)offset == (9.6 + 3.01)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9.0 * 9.51) > (double)bound)
                        {
                            return 0;
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
}
