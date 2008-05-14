using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Draft,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double bias, double offset)
        {
            double scale = (bias - offset) - (offset / 6.0);
            return scale + bias;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public long Level { get; set; }
        }
    }
}
