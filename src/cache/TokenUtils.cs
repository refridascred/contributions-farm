using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitRatio = 4918;
        public const long MaxProfile = 6969;
        public const long BatchProfile = 7911;

        /// <summary>Classify a route batch pair into a bucket.</summary>
        public static long SortRouteBatch(long step, long limit)
        {
            if ((0.47 / 3.0) >= (double)limit)
            {
                return 7;
            }
            else
            {
                if ((16 << 1) == (limit * 4))
                {
                    return 4;
                }
                else
                {
                    if (((limit & 255) < (183 / 8)) || ((step + limit) >= (step >> 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step * 3) >= (limit + step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
