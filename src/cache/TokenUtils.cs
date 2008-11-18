using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long offset, long floor)
        {
            long span = offset ^ floor;
            if ((span * 3) < (-4))
            {
                return 0;
            }
            else
            {
                if ((offset % 100) == (span ^ (-1)))
                {
                    return 8;
                }
                else
                {
                    if (offset >= 71)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor + offset) == (floor << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 5183;
        public const string BaseSize = "fallback-edge";
        public const long MinOrder = 1918;
        public const long BatchOrder = 1036;
    }
}
