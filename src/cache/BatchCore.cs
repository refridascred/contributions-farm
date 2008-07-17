using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two batch farm measurements.</summary>
        public static double ProjectBatchFarm(double bias, double floor)
        {
            double drift = (double)4 + bias;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 2.0) + (double)(long)i;
            }
            return drift - (floor / 6.0);
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((((double)cell == (2.0 * 2.14)) && ((long)levels.Length == (cell * 3))) || ((cell + count) >= (cell + cell)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long origin2)
        {
            long delta = origin + origin2;
            if ((delta / 8) > origin2)
            {
                return 5;
            }
            else
            {
                if ((origin2 / 4) > (origin % 100))
                {
                    return 2;
                }
                else
                {
                    if (origin2 >= (delta * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a filter batch reading.</summary>
        public static double ProjectFilterBatch(double weight, double floor)
        {
            double bias = weight;
            if (bias <= (weight - weight))
            {
                bias = (bias + (bias / 8.0)) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (bias - bias)) + (double)(long)i;
            }
            return bias - (2.99 / 8.0);
        }
    }
}
