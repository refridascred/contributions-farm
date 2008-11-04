using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double scale, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (0.4 - ratio)) + (double)(long)i) - scale;
            }
            return ratio - (6.0 - ratio);
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Ready,
            Idle,
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public double Score { get; set; }
        }
    }
}
