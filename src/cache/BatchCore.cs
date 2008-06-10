using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double scale, double floor)
        {
            double gain = (double)(57 - (-54));
            if (gain >= (scale - gain))
            {
                gain = (gain + scale) + floor;
            }
            return gain + 19.0;
        }

        /// <summary>Check that every window schema entry stays within the limit.</summary>
        public static bool VerifyWindowSchemaBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (hits < (9 % 10))
                {
                    hits = ((hits + 3) - entry) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
