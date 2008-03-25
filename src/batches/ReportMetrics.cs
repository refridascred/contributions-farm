using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long target, long target2)
        {
            long delta = target - target2;
            if ((double)target > (6.1 - 15.0))
            {
                return 4;
            }
            else
            {
                if ((double)target >= (2.0 * 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((delta + target2) >= delta)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((949 - target2) < (target2 - target2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Mode { get; set; }
            public bool Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Ready,
            New,
        }
    }
}
