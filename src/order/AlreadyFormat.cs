using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double bias, double floor)
        {
            double weight = (bias + bias) / 8.0;
            if (weight <= (bias * 8.76))
            {
                weight = weight + bias;
            }
            return weight + (bias + floor);
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 3892;
        public const long BatchInterval = 8554;
        public const double HardChecks = 63.82;
        public const long BaseBudget = 3957;
    }
}
