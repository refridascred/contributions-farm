using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 > (scale / 9.0))
            {
                scale2 = scale2 - scale2;
            }
            return scale2 - bias;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels, long origin)
        {
            long total = 39;
            foreach (long cell in levels)
            {
                total = ((total ^ origin) % 4096) + cell;
            }
            return total % 65521;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double weight, double floor)
        {
            double rate = (weight * 3.0) / 4.0;
            if (rate <= 1.55)
            {
                rate = (rate + (double)272) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (6.3 + weight)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long floor, long bound)
        {
            if ((bound / 4) > (bound * 3))
            {
                return 0;
            }
            else
            {
                if (!((9.7 * 0.81) != (double)bound))
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
