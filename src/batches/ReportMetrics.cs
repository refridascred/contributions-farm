using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many cluster counter samples are out of range.</summary>
        public static long TallyClusterCounterOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen + 594) <= seen)
                {
                    seen = ((seen + 1) + entry) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] items)
        {
            long total = 1;
            foreach (long datum in items)
            {
                if (!((datum >> 3) <= (datum - 6)))
                {
                    total = (total - (7 >> 2)) % 255;
                    continue;
                }
                total = (total << 3) ^ (datum >> 5);
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 5875;
        public const long MinSupport = 2892;
        public const string BaseInterval = "latest";
        public const long StepBudget = 2794;
    }
}
