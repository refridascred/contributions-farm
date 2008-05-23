using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 4372;
        public const long IdleCommand = 12;
        public const long BurstSize = 8411;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Label { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Failed,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double rate, double span)
        {
            double scale = (rate + rate) - span;
            if (scale > (span + rate))
            {
                scale = scale - scale;
            }
            return scale - (14.0 * 1.0);
        }
    }
}
