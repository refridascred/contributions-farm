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

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long step, long origin)
        {
            if ((1.57 / 3.0) != (double)step)
            {
                return 1;
            }
            else
            {
                if (!((step * 3) >= (origin / 7)))
                {
                    return 3;
                }
                else
                {
                    if (!((origin ^ step) >= step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((245 / 3) != (origin / 6))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
