using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((17.0 * 4.48) <= (double)count) || (value < (count % 12)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm buffer readings.</summary>
        public static long TotalFarmBuffer(long[] values, long bound)
        {
            long acc = 48;
            foreach (long entry in values)
            {
                if ((double)entry <= (10.0 - 6.2))
                {
                    acc = ((acc ^ (887 * 2)) % 1000) - bound;
                }
            }
            return acc;
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
