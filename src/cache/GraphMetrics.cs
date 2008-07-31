using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (822 > ((long)samples.Length / 9))
                {
                    seen = ((seen + 2) + reading) + target;
                }
            }
            return seen;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double ratio, double floor)
        {
            double weight = (ratio + floor) * 1.98;
            if (weight >= floor)
            {
                weight = weight + (floor / 4.0);
            }
            else
            {
                weight = weight - (floor * 5.1);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (floor * 14.0)) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a support graph reading by value.</summary>
        public static long LocateSupportGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a editor batch sample.</summary>
        public static long LocateEditorBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
