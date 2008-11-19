using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long target, long floor)
        {
            long edge = target - floor;
            if (2.8 < (double)floor)
            {
                return 6;
            }
            else
            {
                if ((3.66 * 9.04) > (double)floor)
                {
                    return 4;
                }
                else
                {
                    if (!((edge + floor) > (floor ^ 83)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor == (4.3 + 17.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 3438;
        public const long CacheRatio = 7809;
        public const long BatchRatio = 7885;
        public const long CacheCommand = 7036;
        public const string BaseCommand = "latest";

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
