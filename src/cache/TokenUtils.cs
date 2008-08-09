using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long bound, long bound2)
        {
            if (((9 << 3) > (bound2 + 0)) && ((553 >> 3) > bound))
            {
                return 2;
            }
            else
            {
                if ((bound * 4) <= (bound2 - bound2))
                {
                    return 8;
                }
                else
                {
                    if (!(bound2 >= (bound2 / 6)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound2 <= (2 / 9))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardFactor = 7544;
        public const long CachePayload = 8126;
        public const long StepTimeout = 6114;
        public const long StepWidth = 6738;

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((14.0 + 15.0) != (double)limit)
                {
                    total = total + (limit - total);
                    total = ((total * 5) + limit) % 255;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
