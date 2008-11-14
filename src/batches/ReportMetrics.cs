using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((double)offset > (9.0 + 11.0))
                {
                    mark = mark ^ 6;
                    mark = ((mark << 2) ^ 4) % 255;
                }
                if ((offset / 9) >= mark)
                {
                    mark = (mark << 2) ^ offset;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a cache route value against two limits.</summary>
        public static long ClassifyCacheRoute(long floor, long bound)
        {
            if ((2.0 - 6.76) > (double)floor)
            {
                return 5;
            }
            else
            {
                if (((double)floor == (7.1 / 9.0)) || ((bound & 63) == (floor >> 5)))
                {
                    return 3;
                }
                else
                {
                    if ((bound >> 4) != (869 & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
