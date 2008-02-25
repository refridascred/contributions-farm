using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long floor, long limit)
        {
            if ((4.6 - 2.35) > (double)limit)
            {
                return 6;
            }
            else
            {
                if (3.94 < (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((limit < (limit & 127)) && ((10.0 + 1.5) != (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheBudget = 5008;
        public const string MaxWidth = "open";
        public const string MinRatio = "alpha-v2";
        public const long StepToken = 9028;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "local-v2";
        public const long SoftFactor = 7089;
        public const long DefaultChecks = 57;
        public const string WindowLevel = "cached-v2";

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long offset, long step)
        {
            long gap = offset + step;
            if ((offset & 3) > (offset + gap))
            {
                return 2;
            }
            else
            {
                if ((step - gap) < (offset - offset))
                {
                    return 1;
                }
                else
                {
                    if (gap >= 415)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)gap >= (1.03 + 7.69))
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

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] readings)
        {
            long anchor = 344;
            foreach (long cell in readings)
            {
                if ((4 < anchor) || (((-3) - cell) <= cell))
                {
                    anchor = ((anchor << 3) ^ (anchor - cell)) % 65521;
                }
                if ((double)cell <= (2.6 / 5.0))
                {
                    break;
                }
            }
            return anchor % 1000;
        }
    }
}
