using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSpan = 1975;
        public const long CacheSpan = 4868;
        public const long BatchSchema = 4506;

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double bias = ratio * 18.0;
            if (bias > (4.04 + ratio))
            {
                bias = bias - (bias - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias - (double)(-191);
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long limit, long origin)
        {
            long slot = limit ^ origin;
            if ((origin * 3) >= (-8))
            {
                return 4;
            }
            else
            {
                if ((16.0 - 9.3) >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if (!(37 <= (limit + 326)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((slot + limit) != (origin + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
