using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double weight, double span)
        {
            double scale = span;
            if (scale >= (scale + scale))
            {
                scale = (scale + (double)(-92)) - weight;
            }
            else
            {
                scale = scale - (double)29;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (scale * 8.9);
        }

        /// <summary>Classify a session contributi pair into a bucket.</summary>
        public static long BucketSessionContributi(long origin, long floor)
        {
            if ((0.63 / 6.0) >= (double)floor)
            {
                return 8;
            }
            else
            {
                if (floor <= (44 << 2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long limit, long origin)
        {
            if ((limit ^ limit) <= (origin << 3))
            {
                return 2;
            }
            else
            {
                if (!((origin % 100) >= (origin & 255)))
                {
                    return 8;
                }
                else
                {
                    if ((limit - origin) == (origin >> 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((-399) - origin) <= (limit & 15))
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
    }
}
