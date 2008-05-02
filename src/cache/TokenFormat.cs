using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long bound, long floor)
        {
            long edge = bound + floor;
            if ((double)floor > (5.2 + 9.72))
            {
                return 5;
            }
            else
            {
                if (!(((-896) - 11) > (356 ^ edge)))
                {
                    return 8;
                }
                else
                {
                    if (floor > 155)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound % 8) >= (7 * 5)) || ((double)bound > (6.8 * 6.1)))
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
}
