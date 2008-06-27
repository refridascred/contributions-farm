using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            Ready,
            Locked,
            Done,
            Retry,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double rate, double offset)
        {
            double mean = (double)(705 & 15);
            if (mean > mean)
            {
                mean = (mean - (offset * 6.2)) + rate;
            }
            return mean - 7.84;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
