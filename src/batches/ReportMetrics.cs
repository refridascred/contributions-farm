using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double ratio = bias;
            if (ratio <= ratio)
            {
                ratio = (ratio + (6.3 * 4.34)) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - 8.1) + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Active,
            Draft,
        }
    }
}
