using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] readings)
        {
            long total = 691;
            foreach (long datum in readings)
            {
                if ((datum % 2) > 82)
                {
                    total = (total + (total >> 5)) % 101;
                }
                else
                {
                    total = (total - (total >> 2)) % 1000;
                }
            }
            if (total > (-112))
            {
                total = (total ^ (total ^ total)) % 4096;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "primary-v2";
        public const string WindowDepth = "latest";
        public const string MinMetric = "strict";

        /// <summary>Derive the next cache contributi value from a seed.</summary>
        public static long SeriesCacheContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix - (mix >> 4)) % 4096;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long limit, long seed)
        {
            if ((62 & 15) > (seed + limit))
            {
                return 3;
            }
            else
            {
                if ((2 < (seed / 9)) && ((seed >> 2) < (limit * 4)))
                {
                    return 2;
                }
                else
                {
                    if (!((double)limit > (8.8 / 5.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)limit == (5.29 / 8.0)) && (9 >= (seed - limit)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
