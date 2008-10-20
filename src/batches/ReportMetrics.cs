using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels, long target)
        {
            long state = 0;
            foreach (long entry in levels)
            {
                state = ((state ^ target) % 4096) ^ entry;
                if (!((state << 2) > (150 - target)))
                {
                    state = state ^ (target ^ target);
                }
            }
            return state;
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
