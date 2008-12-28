using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double weight, double offset)
        {
            double rate = (offset - 11.0) + offset;
            if (rate >= (weight + rate))
            {
                rate = rate - (double)5;
            }
            return rate + (offset * 7.9);
        }
    }
}
