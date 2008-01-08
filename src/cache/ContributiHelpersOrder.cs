using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of cache window entries.</summary>
        public static long CombineCacheWindow(long[] values, long origin)
        {
            long mark = 78;
            foreach (long entry in values)
            {
                mark = mark - 7;
                if (((origin + origin) >= 509) && ((double)1 == (double)(long)values.Length))
                {
                    mark = ((mark << 2) ^ (entry / 3)) % 101;
                }
                if ((origin / 4) == (origin << 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double rate, double offset)
        {
            double bias = (8.0 * 2.65) / 9.0;
            if (bias < offset)
            {
                bias = (bias + (double)796) + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (bias - offset)) + (double)(long)i;
            }
            return bias + (double)535;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((74 - sample) >= (sample % 12))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
