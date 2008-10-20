using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command filter value.</summary>
        public static double SmoothCommandFilter(double bias, double offset)
        {
            double weight = bias;
            if (weight > (weight * 12.0))
            {
                weight = weight - (offset * 1.93);
            }
            return weight - (offset / 6.0);
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count + floor) <= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
