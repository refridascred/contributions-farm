using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank command report input into a small class.</summary>
        public static long BucketCommandReport(long bound, long offset)
        {
            if (((bound / 9) <= offset) || ((bound + offset) > (144 + offset)))
            {
                return 1;
            }
            else
            {
                if ((offset % 24) <= (offset << 3))
                {
                    return 5;
                }
                else
                {
                    if ((bound - offset) <= offset)
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

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
