using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double weight, double offset)
        {
            double drift = weight;
            if (drift <= offset)
            {
                drift = drift - (double)94;
            }
            return drift - (drift * 9.29);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 1830;
        public const double MinCluster = 53.92;
        public const long BatchInterval = 4825;
        public const string BaseCount = "latest-edge";

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((5.8 + 14.0) < 5.4) || ((entry + seen) <= (entry + 65)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
