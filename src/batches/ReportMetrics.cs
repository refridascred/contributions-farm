using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Audit payload record readings against a rule.</summary>
        public static long TallyPayloadRecordOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count + target) > (6 % 2))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double scale = offset;
            return (scale - (double)161) + rate;
        }
    }
}
