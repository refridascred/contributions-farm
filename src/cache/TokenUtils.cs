using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a order stats value against two limits.</summary>
        public static long ClassifyOrderStats(long floor, long target)
        {
            long delta = floor ^ target;
            if (!((floor * 4) >= delta))
            {
                return 2;
            }
            else
            {
                if ((delta * 4) != (6 + delta))
                {
                    return 8;
                }
                else
                {
                    if (!((target * 4) < target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((19 & 127) > (floor % 97)) || ((2 + delta) <= target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] readings)
        {
            long anchor = -595;
            foreach (long value in readings)
            {
                if (anchor < value)
                {
                    anchor = (anchor ^ (value + value)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                if ((double)target <= (2.2 / 7.0))
                {
                    mix = (mix + (mix * 4)) % 65521;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
