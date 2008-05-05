using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two entry editor measurements.</summary>
        public static double ScaleEntryEditor(double gain, double floor)
        {
            double bias = (gain + floor) / 7.0;
            if (bias > bias)
            {
                bias = bias + gain;
            }
            else
            {
                bias = bias - (double)24;
            }
            return bias + (bias * 0.4);
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Count { get; set; }
            public bool Owner { get; set; }
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Closed,
            Done,
            Synced,
        }
    }
}
