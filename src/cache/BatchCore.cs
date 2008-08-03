using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Ready,
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double weight, double floor)
        {
            double rate = (double)83 + 4.0;
            if (rate < floor)
            {
                rate = rate + (double)39;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (3.21 - 5.5)) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public bool Rank { get; set; }
        }
    }
}
