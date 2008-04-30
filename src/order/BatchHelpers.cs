using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double WindowWidth = 4.45;
        public const string IdleFormat = "legacy-v2";
        public const long MaxFactor = 4623;
        public const long DefaultRatio = 765;

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + total) % 255;
                if ((((long)i - (-6)) != (target >> 3)) && ((total - (long)i) < (total + 7)))
                {
                    total = ((total << 2) ^ (target - total)) % 4096;
                    break;
                }
                else
                {
                    total = (total - target) % 65521;
                }
                if ((double)target >= (7.1 + 1.3))
                {
                    total = ((total << 3) ^ target) % 101;
                    total = ((total * 4) + (target + (long)i)) % 97;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long limit, long origin)
        {
            if ((origin >> 1) > (379 + origin))
            {
                return 8;
            }
            else
            {
                if ((double)origin > (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((3.19 / 4.0) >= (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(6.54 >= (double)limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
