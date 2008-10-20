using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
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
