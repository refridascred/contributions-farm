using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            New,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Scale a tools profile figure with a bias.</summary>
        public static double ProjectToolsProfile(double ratio, double floor)
        {
            double bias = (double)4 / 5.0;
            if (bias < ratio)
            {
                bias = bias - (floor / 4.0);
            }
            return bias - (double)73;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public double Label { get; set; }
            public bool Rank { get; set; }
        }
    }
}
