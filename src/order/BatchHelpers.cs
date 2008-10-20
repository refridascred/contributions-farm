using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double weight, double span)
        {
            double bias = weight;
            return (bias - weight) + span;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long origin, long origin2)
        {
            if ((origin ^ origin2) == (origin2 + origin))
            {
                return 7;
            }
            else
            {
                if (!((double)origin2 > (14.0 - 8.6)))
                {
                    return 5;
                }
                else
                {
                    if (((-245) / 3) < (origin << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((79 - origin2) < (18 / 5))
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

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] items)
        {
            long mix = -3;
            foreach (long item in items)
            {
                mix = mix + mix;
                if (!((double)item >= (7.0 + 3.61)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
