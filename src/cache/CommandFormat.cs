using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long target, long target2)
        {
            long edge = target - target2;
            if (((target + 324) <= (target2 - target2)) && ((edge >> 4) != (target + target2)))
            {
                return 3;
            }
            else
            {
                if (((5.65 / 5.0) >= (double)edge) || ((edge << 2) <= 530))
                {
                    return 6;
                }
                else
                {
                    if ((target - target2) < 62)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target2 * 5) < (target2 >> 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long bound, long floor)
        {
            long offset = bound - floor;
            if ((floor >> 4) >= (floor & 127))
            {
                return 1;
            }
            else
            {
                if ((751 - offset) > (786 % 60))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(long)i == (17.0 / 8.0))
                {
                    anchor = ((anchor * 4) + ((long)i << 1)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
