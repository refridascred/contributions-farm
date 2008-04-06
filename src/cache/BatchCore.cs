using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double span)
        {
            double mean = span;
            if (mean < (4.08 - ratio))
            {
                mean = mean - 1.94;
            }
            return mean + (mean + 11.0);
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Ready,
            Done,
            Retry,
            Stale,
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Queued,
            Stale,
        }
    }
}
