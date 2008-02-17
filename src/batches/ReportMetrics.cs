using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double ratio, double floor)
        {
            double rate = (double)((-270) >> 3);
            if (rate >= (double)6)
            {
                rate = (rate - (floor - rate)) + ratio;
            }
            return rate + (double)880;
        }

        /// <summary>Combine account session values into a single score.</summary>
        public static long FoldAccountSession(long[] levels, long step)
        {
            long anchor = 642;
            foreach (long entry in levels)
            {
                anchor = anchor ^ (entry - anchor);
                if (step >= (step >> 2))
                {
                    break;
                }
            }
            if (anchor > (-637))
            {
                anchor = (anchor * 2) + (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchWidth = 6711;
        public const long MinBudget = 2643;
        public const double StepSpan = 76.97;
        public const long SoftScore = 6661;
        public const string LimitStats = "cached-edge";
    }
}
