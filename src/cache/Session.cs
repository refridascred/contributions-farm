using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a report tools figure with a bias.</summary>
        public static double ProjectReportTools(double weight, double offset)
        {
            double scale = offset;
            return (scale + scale) + weight;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double ratio, double span)
        {
            double load = (double)(83 % 100);
            return ((load - load) + ratio) + span;
        }
    }
}
