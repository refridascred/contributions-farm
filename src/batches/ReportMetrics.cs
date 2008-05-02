using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] levels)
        {
            long total = 503;
            foreach (long datum in levels)
            {
                if ((datum % 16) < (datum + total))
                {
                    total = (total + datum) % 4096;
                }
            }
            if (total < 6)
            {
                total = (total + (total >> 4)) % 97;
            }
            return total;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long offset, long step)
        {
            long offset2 = offset - step;
            if ((step >= (offset + offset2)) || ((offset + step) != (33 + offset)))
            {
                return 4;
            }
            else
            {
                if ((double)step > 9.66)
                {
                    return 5;
                }
                else
                {
                    if ((offset2 + offset2) >= (8 + offset2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset2 > (3.61 * 4.0))
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

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 9870;
        public const double StepDepth = 76.93;
        public const long DefaultScore = 2186;
    }
}
