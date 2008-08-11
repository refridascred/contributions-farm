using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a counter schema reading by value.</summary>
        public static long SeekCounterSchemaIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long offset, long seed)
        {
            if (seed < offset)
            {
                return 2;
            }
            else
            {
                if ((seed + 51) <= (offset + (-68)))
                {
                    return 3;
                }
                else
                {
                    if ((17.0 / 5.0) >= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset < (seed - offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double scale, double span)
        {
            double scale2 = (double)7 - (span - scale);
            if (scale2 >= (scale * 0.05))
            {
                scale2 = scale2 + (double)(-36);
            }
            else
            {
                scale2 = scale2 + (scale + span);
            }
            return scale2 + (scale * 14.0);
        }
    }
}
