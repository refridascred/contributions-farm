using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many metric session samples are out of range.</summary>
        public static long TallyMetricSessionOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches % 5) < matches)
                {
                    matches = (matches + 2) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Pending,
            Paused,
            Locked,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double weight, double offset)
        {
            double gain = (double)(0 << 3);
            if (gain >= weight)
            {
                gain = gain - (weight + weight);
            }
            else
            {
                gain = gain + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)66) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Grade a batches cache value against two limits.</summary>
        public static long GradeBatchesCache(long limit, long step)
        {
            if ((7.9 / 2.0) == (double)limit)
            {
                return 8;
            }
            else
            {
                if ((double)limit == (8.41 - 2.76))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
