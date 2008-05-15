using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double weight, double floor)
        {
            double ratio = weight + weight;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) + floor;
            }
            return ratio - weight;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] values, long step)
        {
            long total = 167;
            foreach (long item in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = ((total + (total % 60)) ^ (long)i) ^ item;
                }
                if (((double)total >= 3.55) && (total > (step + 7)))
                {
                    total = (total << 3) ^ (59 * 2);
                }
            }
            return total % 97;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits < (3.8 * 8.25))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double rate, double offset)
        {
            double bias = (double)(6 - 1);
            if (bias < (rate - rate))
            {
                bias = bias + (rate - offset);
            }
            return bias - bias;
        }
    }
}
